using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class RepositorioCategoriasBd : IRepositorioCategorias<Categoria>
    {
        public RepositorioCategoriasBd()
        {

        }

        public void Agregar(Categoria categoriaAAgregar)
        {
            using (var contexto = new ContextoGestorBd())
            {
                bool existeCategoriaConEseNombre = contexto.Categorias.Any(categoria => categoria.Id == categoriaAAgregar.Id)
                 || contexto.Categorias.Any(categoria => categoria.Nombre == categoriaAAgregar.Nombre);
                if (existeCategoriaConEseNombre)
                {
                    throw new ExcepcionCategoriaYaExistente();
                }
                else
                {
                    EntidadCategoria entidadCategoriaAAgregar = ConvertirAEntidadCategoria(categoriaAAgregar);
                    contexto.Categorias.Add(entidadCategoriaAAgregar);
                    contexto.SaveChanges();
                    categoriaAAgregar.Id = entidadCategoriaAAgregar.Id;
                }
            }
        }

        public int Contar()
        {
            using (var contexto = new ContextoGestorBd())
            {
                int cantidad = 0;
                cantidad = contexto.Categorias.Count();
                return cantidad;
            }
        }

        public ICollection<Categoria> DarColeccion()
        {
            using (var contexto = new ContextoGestorBd())
            {
                ICollection<Categoria> categorias = new List<Categoria>();
                ICollection<EntidadCategoria> categoriasDelContexto = contexto.Categorias.ToList();
                foreach (EntidadCategoria entidadCategoria in categoriasDelContexto)
                {
                    categorias.Add(ConvertirAObjetoCategoria(entidadCategoria));
                }
                return categorias;
            }
        }

        public void Editar(string nombreCategoria, string nuevoNombre)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadCategoria entidadEncontrada = contexto.Categorias.FirstOrDefault(categoria => categoria.Nombre == nombreCategoria);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteCategoria();
                }
                entidadEncontrada.Nombre = nuevoNombre;
                contexto.SaveChanges();
            }

        }

        public Categoria Obtener(string nombre)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadCategoria entidadEncontrada = contexto.Categorias.FirstOrDefault(categoria => categoria.Nombre == nombre);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteCategoria();
                }
                return ConvertirAObjetoCategoria(entidadEncontrada);
            }

        }

        private EntidadCategoria ConvertirAEntidadCategoria(Categoria categoria)
        {
            EntidadCategoria entidadCategoria = new EntidadCategoria();
            entidadCategoria.Id = categoria.Id;
            entidadCategoria.Nombre = categoria.Nombre;
            entidadCategoria.Pares = MapearParesDeLaCategoria(categoria);
            entidadCategoria.Tarjetas = MapearTarjetasDeLaCategoria(categoria);
            return entidadCategoria;
        }

        private Categoria ConvertirAObjetoCategoria(EntidadCategoria entidadCategoria)
        {
            Categoria categoria = new Categoria(entidadCategoria.Nombre);
            categoria.Id = entidadCategoria.Id;
            List<ParUsuarioContrasena> paresDeLaCategoria = ObtenerParesEnObjeto(entidadCategoria);
            List<TarjetaDeCredito> tarjetasDeCredito = ObtenerTarjetasEnObjeto(entidadCategoria);
            foreach (ParUsuarioContrasena par in paresDeLaCategoria)
            {
                categoria.AgregarParUsuarioContrasena(par);
            }
            foreach (TarjetaDeCredito tarjeta in tarjetasDeCredito)
            {
                categoria.AgregarTarjetaDeCredito(tarjeta);
            }
            return categoria;
        }

        private List<TarjetaDeCredito> ObtenerTarjetasEnObjeto(EntidadCategoria entidadCategoria)
        {
            List<TarjetaDeCredito> tarjetasEnObjeto = new List<TarjetaDeCredito>();
            if (entidadCategoria.Tarjetas != null)
            {
                foreach (EntidadTarjetaDeCredito entidadTarjeta in entidadCategoria.Tarjetas)
                {
                    if (!entidadTarjeta.EstaBorrada)
                    {
                        TarjetaDeCredito tarjetaEnObjeto = ConvertirAObjetoTarjeta(entidadTarjeta);
                        tarjetasEnObjeto.Add(tarjetaEnObjeto);
                    }
                }
            }
            return tarjetasEnObjeto;
        }

        private List<ParUsuarioContrasena> ObtenerParesEnObjeto(EntidadCategoria entidadCategoria)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                List<ParUsuarioContrasena> paresEnObjeto = new List<ParUsuarioContrasena>();
                List<EntidadParUsuarioContrasena> entidadesParesDelContexto = contexto.Pares.Include("Categoria").Include("Contrasena").ToList();
                foreach (EntidadParUsuarioContrasena entidadPar in entidadesParesDelContexto)
                {
                    if (entidadPar.Categoria.Id == entidadCategoria.Id && !entidadPar.EstaBorrada)
                    {
                        ParUsuarioContrasena parEnObjeto = ConvertirAObjetoPar(entidadPar);
                        paresEnObjeto.Add(parEnObjeto);
                    }
                }


                return paresEnObjeto;
            }
        }

        private ICollection<EntidadParUsuarioContrasena> MapearParesDeLaCategoria(Categoria categoria)
        {
            ICollection<EntidadParUsuarioContrasena> entidadesParUsuarioContrasna = new List<EntidadParUsuarioContrasena>();
            foreach (ParUsuarioContrasena par in categoria.DarTodasLasContrasenas())
            {
                EntidadParUsuarioContrasena entidadParAAgregar = ConvertirAEntidadPar(par);
                entidadesParUsuarioContrasna.Add(entidadParAAgregar);
            }
            return entidadesParUsuarioContrasna;
        }

        private ICollection<EntidadTarjetaDeCredito> MapearTarjetasDeLaCategoria(Categoria categoria)
        {
            ICollection<EntidadTarjetaDeCredito> entidadesTarjetaDeCredito = new List<EntidadTarjetaDeCredito>();

            foreach (TarjetaDeCredito tarjeta in categoria.DarTarjetasDeCredito())
            {
                EntidadTarjetaDeCredito entidadParAAgregar = ConvertirAEntidadTarjeta(tarjeta);
                entidadesTarjetaDeCredito.Add(entidadParAAgregar);
            }
            return entidadesTarjetaDeCredito;
        }

        private EntidadTarjetaDeCredito ConvertirAEntidadTarjeta(TarjetaDeCredito tarjeta)
        {
            EntidadTarjetaDeCredito entidadTarjeta = new EntidadTarjetaDeCredito();
            entidadTarjeta.Id = tarjeta.Id;
            entidadTarjeta.Codigo = tarjeta.Codigo;
            entidadTarjeta.Nombre = tarjeta.Nombre;
            entidadTarjeta.Tipo = tarjeta.Tipo;
            entidadTarjeta.Categoria = ConvertirAEntidadCategoria(Obtener(tarjeta.Categoria.Nombre));
            entidadTarjeta.CodigoDeSeguridad = tarjeta.CodigoDeSeguridad;
            entidadTarjeta.Nota = tarjeta.Nota;
            return entidadTarjeta;
        }

        private EntidadParUsuarioContrasena ConvertirAEntidadPar(ParUsuarioContrasena par)
        {
            EntidadParUsuarioContrasena entidadPar = new EntidadParUsuarioContrasena();
            entidadPar.Id = par.Id;
            entidadPar.NombreDeUsuario = par.NombreDeUsuario;
            entidadPar.Sitio = par.Sitio;
            entidadPar.Nota = par.Nota;
            entidadPar.Contrasena = ConvertirAEntidadContrasena(par.Contrasena);
            return entidadPar;
        }

        private TarjetaDeCredito ConvertirAObjetoTarjeta(EntidadTarjetaDeCredito entidadTarjeta)
        {
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            tarjeta.Id = entidadTarjeta.Id;
            tarjeta.Codigo = entidadTarjeta.Codigo;
            tarjeta.Nombre = entidadTarjeta.Nombre;
            tarjeta.Tipo = entidadTarjeta.Tipo;
            tarjeta.CodigoDeSeguridad = entidadTarjeta.CodigoDeSeguridad;
            tarjeta.Nota = entidadTarjeta.Nota;
            return tarjeta;
        }

        private ParUsuarioContrasena ConvertirAObjetoPar(EntidadParUsuarioContrasena entidadPar)
        {
            ParUsuarioContrasena par = new ParUsuarioContrasena();
            par.Id = entidadPar.Id;
            par.NombreDeUsuario = entidadPar.NombreDeUsuario;
            par.Sitio = entidadPar.Sitio;
            par.Nota = entidadPar.Nota;
            par.Contrasena = ConvertirAObjetoContrasena(entidadPar.Contrasena);
            par.Modificado = entidadPar.FueModificada;
            return par;
        }

        private Contrasena ConvertirAObjetoContrasena(EntidadContrasena entidadContrasena)
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = entidadContrasena.Clave;
            contrasena.GrupoDeFortaleza = entidadContrasena.GrupoDeFortaleza;
            contrasena.Id = entidadContrasena.Id;
            return contrasena;
        }

        private EntidadContrasena ConvertirAEntidadContrasena(Contrasena contrasena)
        {
            EntidadContrasena entidadContrasena = new EntidadContrasena();
            entidadContrasena.Clave = contrasena.Clave;
            entidadContrasena.Id = contrasena.Id;
            entidadContrasena.GrupoDeFortaleza = contrasena.GrupoDeFortaleza;
            entidadContrasena.UltimaModificacion = contrasena.UltimaModificacion;
            return entidadContrasena;
        }
    }
}
