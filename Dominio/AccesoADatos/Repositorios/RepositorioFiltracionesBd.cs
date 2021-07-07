using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class RepositorioFiltracionesBd : IRepositorioFiltraciones<Filtracion, int>
    {
        public void Agregar(Filtracion filtracion)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                EntidadFiltracion entidadAAgregar = ConvertirAEntidadFiltracion(filtracion);
                contexto.Filtraciones.Add(entidadAAgregar);
                foreach (EntidadParUsuarioContrasena entidadPar in entidadAAgregar.Pares)
                {
                    AtachearParesALaBase(contexto, entidadPar);
                }
                foreach (EntidadTarjetaDeCredito entidadTarjeta in entidadAAgregar.Tarjetas)
                {
                    AtachearTarjetasALaBase(contexto, entidadTarjeta);
                }
                contexto.SaveChanges();
            }

        }

        public ICollection<Filtracion> DarColeccion()
        {
            using (var contexto = new ContextoGestorBd())
            {
                ICollection<Filtracion> historialDeFiltraciones = new List<Filtracion>();
                ICollection<EntidadFiltracion> entidadesFiltraciones = contexto.Filtraciones.ToList();
                foreach (EntidadFiltracion entidad in entidadesFiltraciones)
                {
                    historialDeFiltraciones.Add(ConvertirAObjetoFiltracion(entidad));
                }
                return historialDeFiltraciones;
            }
        }

        public Filtracion Obtener(int id)
        {
            using (var contexto = new ContextoGestorBd())
            {
                return ConvertirAObjetoFiltracion(contexto.Filtraciones.FirstOrDefault(filtracion => filtracion.Id == id));
            }
        }

        public ICollection<ParUsuarioContrasena> DarTodasContrasenasFiltradas()
        {
            List<ParUsuarioContrasena> paresDeTodasLasFiltraciones = new List<ParUsuarioContrasena>();
            foreach (Filtracion filtracion in DarColeccion())
            {
                UnirParesDeListas(filtracion.ParesDeLaFiltracion, paresDeTodasLasFiltraciones);
            }
            return paresDeTodasLasFiltraciones;
        }

        public ICollection<TarjetaDeCredito> DarTodasTarjetasFiltradas()
        {
            List<TarjetaDeCredito> tarjetasDeTodasLasFiltraciones = new List<TarjetaDeCredito>();
            foreach (Filtracion filtracion in DarColeccion())
            {
                UnirTarjetasDeListas(filtracion.TarjetasDeLaFiltracion, tarjetasDeTodasLasFiltraciones);
            }
            return tarjetasDeTodasLasFiltraciones;
        }

        private EntidadFiltracion ConvertirAEntidadFiltracion(Filtracion filtracion)
        {
            EntidadFiltracion entidadARetornar = new EntidadFiltracion();
            ICollection<ParUsuarioContrasena> paresAConvertir = filtracion.ParesDeLaFiltracion;
            ICollection<TarjetaDeCredito> tarjetasAConveritr = filtracion.TarjetasDeLaFiltracion;
            entidadARetornar.FechaCreacion = filtracion.FechaCreacion;
            entidadARetornar.Pares = ConvertirParesAEntidad(paresAConvertir);
            entidadARetornar.Tarjetas = ConvertirTarjetasAEntidad(tarjetasAConveritr);
            return entidadARetornar;
        }

        private void UnirTarjetasDeListas(ICollection<TarjetaDeCredito> listaAUnir, ICollection<TarjetaDeCredito> listaDestino)
        {
            foreach (TarjetaDeCredito tarjetaAUnir in listaAUnir)
            {
                if (!listaDestino.Contains(tarjetaAUnir))
                {
                    listaDestino.Add(tarjetaAUnir);
                }
            }
        }

        private void UnirParesDeListas(ICollection<ParUsuarioContrasena> listaAUnir, ICollection<ParUsuarioContrasena> listaDestino)
        {
            foreach (ParUsuarioContrasena parAUnir in listaAUnir)
            {
                if (!listaDestino.Contains(parAUnir))
                {
                    listaDestino.Add(parAUnir);
                }
            }
        }

        private ICollection<EntidadParUsuarioContrasena> ConvertirParesAEntidad(ICollection<ParUsuarioContrasena> paresAConvertir)
        {
            ICollection<EntidadParUsuarioContrasena> listaEntidadesParesARetornar = new List<EntidadParUsuarioContrasena>();
            foreach (ParUsuarioContrasena parAConvertir in paresAConvertir)
            {
                listaEntidadesParesARetornar.Add(ConvertirAEntidadPar(parAConvertir));
            }
            return listaEntidadesParesARetornar;
        }

        private ICollection<EntidadTarjetaDeCredito> ConvertirTarjetasAEntidad(ICollection<TarjetaDeCredito> tarjetasAConvertir)
        {
            ICollection<EntidadTarjetaDeCredito> listaEntidadesTarjetaDeCredito = new List<EntidadTarjetaDeCredito>();
            foreach (TarjetaDeCredito tarjetaAConvertir in tarjetasAConvertir)
            {
                listaEntidadesTarjetaDeCredito.Add(ConvertirAEntidadTarjeta(tarjetaAConvertir));
            }
            return listaEntidadesTarjetaDeCredito;
        }

        private EntidadTarjetaDeCredito ConvertirAEntidadTarjeta(TarjetaDeCredito tarjeta)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadTarjeta = new EntidadTarjetaDeCredito();
                entidadTarjeta.Id = tarjeta.Id;
                return entidadTarjeta;
            }
        }

        private EntidadParUsuarioContrasena ConvertirAEntidadPar(ParUsuarioContrasena par)
        {
            EntidadParUsuarioContrasena entidadPar = new EntidadParUsuarioContrasena();
            entidadPar.Id = par.Id;
            return entidadPar;
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

        public Filtracion ConvertirAObjetoFiltracion(EntidadFiltracion entidadFiltracion)
        {
            Filtracion filtracionARetornar = new Filtracion();
            filtracionARetornar.Id = entidadFiltracion.Id;
            filtracionARetornar.FechaCreacion = entidadFiltracion.FechaCreacion;
            filtracionARetornar.ParesDeLaFiltracion = ObtenerParesEnObjeto(entidadFiltracion);
            filtracionARetornar.TarjetasDeLaFiltracion = ObtenerTarjetasEnObjeto(entidadFiltracion);
            return filtracionARetornar;
        }

        private List<ParUsuarioContrasena> ObtenerParesEnObjeto(EntidadFiltracion entidadFiltracion)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                List<ParUsuarioContrasena> paresEnObjeto = new List<ParUsuarioContrasena>();
                ICollection<EntidadParUsuarioContrasena> paresDelContexto = contexto.Pares.Include("Contrasena").Include("Filtraciones").Include("Categoria").ToList();
                if (entidadFiltracion.Pares != null)
                {
                    foreach (EntidadParUsuarioContrasena entidadPar in paresDelContexto)
                    {
                        if (entidadPar.Filtraciones.Any(filtracionABuscar => filtracionABuscar.Id == entidadFiltracion.Id))
                        {
                            ParUsuarioContrasena parEnObjeto = ConvertirAObjetoPar(entidadPar);
                            paresEnObjeto.Add(parEnObjeto);
                        }
                    }
                }
                return paresEnObjeto;
            }
        }

        private List<TarjetaDeCredito> ObtenerTarjetasEnObjeto(EntidadFiltracion entidadFiltracion)
        {
            List<TarjetaDeCredito> tarjetasEnObjeto = new List<TarjetaDeCredito>();
            if (entidadFiltracion.Tarjetas != null)
            {
                foreach (EntidadTarjetaDeCredito entidadTarjeta in entidadFiltracion.Tarjetas)
                {
                    TarjetaDeCredito tarjetaEnObjeto = ConvertirAObjetoTarjeta(entidadTarjeta);
                    tarjetasEnObjeto.Add(tarjetaEnObjeto);
                }
            }
            return tarjetasEnObjeto;
        }

        private ParUsuarioContrasena ConvertirAObjetoPar(EntidadParUsuarioContrasena entidadPar)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                ParUsuarioContrasena par = new ParUsuarioContrasena();
                par.Id = entidadPar.Id;
                par.NombreDeUsuario = entidadPar.NombreDeUsuario;
                par.Sitio = entidadPar.Sitio;
                par.Nota = entidadPar.Nota;
                if (entidadPar.Categoria != null)
                {
                    par.Categoria = ConvertirAObjetoCategoria(entidadPar.Categoria);
                }
                par.Contrasena = ConvertirAObjetoContrasena(entidadPar.Contrasena);
                par.Modificado = entidadPar.FueModificada;
                return par;
            }
        }

        private Categoria ConvertirAObjetoCategoria(EntidadCategoria entidadCategoriaAConvertir)
        {
            string nombreCategoria = entidadCategoriaAConvertir.Nombre;
            Categoria categoriaARetornar = new Categoria(nombreCategoria);
            categoriaARetornar.Id = entidadCategoriaAConvertir.Id;
            return categoriaARetornar;
        }

        private Contrasena ConvertirAObjetoContrasena(EntidadContrasena entidadContrasena)
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = entidadContrasena.Clave;
            contrasena.GrupoDeFortaleza = entidadContrasena.GrupoDeFortaleza;
            contrasena.Id = entidadContrasena.Id;
            return contrasena;
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

        private void AtachearParesALaBase(ContextoGestorBd contexto, EntidadParUsuarioContrasena entidadPar)
        {
            contexto.Entry(entidadPar).State = System.Data.Entity.EntityState.Unchanged;
        }

        private void AtachearTarjetasALaBase(ContextoGestorBd contexto, EntidadTarjetaDeCredito entidadTarjeta)
        {
            contexto.Entry(entidadTarjeta).State = System.Data.Entity.EntityState.Unchanged;
        }
    }
}
