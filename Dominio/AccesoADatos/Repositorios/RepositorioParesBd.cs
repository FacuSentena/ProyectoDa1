using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class RepositorioParesBd : IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena>
    {
        public void Agregar(ParUsuarioContrasena unPar)
        {
            using (var contexto = new ContextoGestorBd())
            {
                string nombreCategoria = unPar.Categoria.Nombre;
                if (!ContienePar(DarColeccion(), unPar.NombreDeUsuario, unPar.Sitio))
                {
                    EntidadParUsuarioContrasena entidadAAgregar = new EntidadParUsuarioContrasena();
                    entidadAAgregar = ConvertirAEntidadPar(unPar);
                    entidadAAgregar.Categoria = contexto.Categorias.FirstOrDefault(categoria => categoria.Nombre == nombreCategoria);
                    contexto.Pares.Add(entidadAAgregar);
                    contexto.SaveChanges();
                }
                else
                {
                    throw new ExcepcionParUsuarioContrasenaYaExistente();
                }
            }

        }

        public int Contar()
        {
            return DarColeccion().Count();
        }

        public ICollection<ParUsuarioContrasena> DarColeccion()
        {
            List<EntidadParUsuarioContrasena> listaEntidadesPares = null;
            using (var contexto = new ContextoGestorBd())
            {
                listaEntidadesPares = contexto.Pares.Include("Categoria").Include("Contrasena").ToList();
            }
            ICollection<ParUsuarioContrasena> pares = new List<ParUsuarioContrasena>();
            foreach (EntidadParUsuarioContrasena entidadPar in listaEntidadesPares)
            {
                if (!entidadPar.EstaBorrada)
                {
                    pares.Add(ConvertirAObjetoPar(entidadPar));
                }
            }
            return pares;
        }

        public void EditarContrasena(string nombre, string sitio, Contrasena nuevaContrasena)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadParUsuarioContrasena entidadAEditarContrasena = contexto.Pares.Include("Contrasena").FirstOrDefault(par => par.NombreDeUsuario == nombre
                && par.Sitio == sitio);
                contexto.Contrasenas.Remove(entidadAEditarContrasena.Contrasena);
                entidadAEditarContrasena.Contrasena = ConvertirAEntidadContrasena(nuevaContrasena);
                entidadAEditarContrasena.FueModificada = true;
                entidadAEditarContrasena.Contrasena.UltimaModificacion = DateTime.Now;
                contexto.SaveChanges();
            }
        }

        public void EditarNombreYSitio(ParUsuarioContrasena parAEditar, string nuevoNombre, string nuevoSitio)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadParUsuarioContrasena entidadAEditarNombre = contexto.Pares.FirstOrDefault(par => par.NombreDeUsuario == parAEditar.NombreDeUsuario
                                    && par.Sitio == parAEditar.Sitio);
                if (ContienePar(DarColeccion(), nuevoNombre, nuevoSitio))
                {
                    throw new ExcepcionParUsuarioContrasenaYaExistente();
                }
                else
                {
                    entidadAEditarNombre.NombreDeUsuario = nuevoNombre;
                    entidadAEditarNombre.Sitio = nuevoSitio;
                    contexto.SaveChanges();
                }
            }

        }

        public void Eliminar(string nombre, string sitio)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadParUsuarioContrasena entidadParAEliminar = contexto.Pares.Include("Contrasena").FirstOrDefault
                (par => par.NombreDeUsuario == nombre && par.Sitio == sitio && !par.EstaBorrada);
                entidadParAEliminar.EstaBorrada = true;
                contexto.SaveChanges();
            }
        }

        public ParUsuarioContrasena Obtener(string nombre, string sitio)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadParUsuarioContrasena entidadPar = contexto.Pares.Include("Contrasena").Include("Categoria").FirstOrDefault(par => par.NombreDeUsuario == nombre && par.Sitio == sitio && !par.EstaBorrada);
                if (entidadPar == null || entidadPar.EstaBorrada)
                {
                    throw new ExcepcionParUsuarioContrasenaNoExistente();
                }
                return ConvertirAObjetoPar(entidadPar);
            }
        }

        public ICollection<ParUsuarioContrasena> ObtenerParesPorGrupoDeSeguridad(string colorDeGrupoDeSeguriad)
        {
            ICollection<ParUsuarioContrasena> paresFiltradosPorGrupo = new List<ParUsuarioContrasena>();
            ICollection<ParUsuarioContrasena> paresSinFiltrar = DarColeccion();
            foreach (ParUsuarioContrasena parDeLaColeccionSinFiltrar in paresSinFiltrar)
            {
                if (parDeLaColeccionSinFiltrar.Contrasena.GrupoDeFortaleza == colorDeGrupoDeSeguriad)
                {
                    paresFiltradosPorGrupo.Add(parDeLaColeccionSinFiltrar);
                }
            }
            return paresFiltradosPorGrupo;
        }

        private EntidadParUsuarioContrasena ConvertirAEntidadPar(ParUsuarioContrasena par)
        {
            EntidadParUsuarioContrasena entidadPar = new EntidadParUsuarioContrasena();
            entidadPar.Id = par.Id;
            entidadPar.NombreDeUsuario = par.NombreDeUsuario;
            entidadPar.Sitio = par.Sitio;
            entidadPar.Nota = par.Nota;
            entidadPar.Contrasena = ConvertirAEntidadContrasena(par.Contrasena);
            entidadPar.EstaBorrada = false;
            entidadPar.FueModificada = false;
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

        private ParUsuarioContrasena ConvertirAObjetoPar(EntidadParUsuarioContrasena entidadParAConvertir)
        {
            ParUsuarioContrasena parARetornar = new ParUsuarioContrasena();
            parARetornar.Id = entidadParAConvertir.Id;
            parARetornar.NombreDeUsuario = entidadParAConvertir.NombreDeUsuario;
            parARetornar.Sitio = entidadParAConvertir.Sitio;
            parARetornar.Contrasena = ConvertirAObjetoContrasena(entidadParAConvertir.Contrasena);
            parARetornar.Nota = entidadParAConvertir.Nota;
            parARetornar.Categoria = ConvertirAObjetoCategoria(entidadParAConvertir.Categoria);
            parARetornar.Modificado = entidadParAConvertir.FueModificada;
            return parARetornar;
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
            contrasena.UltimaModificacion = entidadContrasena.UltimaModificacion;
            return contrasena;
        }

        private bool ContienePar(ICollection<ParUsuarioContrasena> pares, string nombreUsuario, string nombreSitio)
        {
            ParUsuarioContrasena parParaBuscar = pares.FirstOrDefault(par => par.NombreDeUsuario == nombreUsuario
            && par.Sitio == nombreSitio);
            if (parParaBuscar == null)
            {
                return false;
            }
            return true;
        }

        public bool ContrasenaYaExistente(ParUsuarioContrasena parAChequear)
        {
            ICollection<ParUsuarioContrasena> paresTotales = this.DarColeccion();
            foreach (ParUsuarioContrasena par in paresTotales)
            {
                bool nombreDistinto = par.NombreDeUsuario != parAChequear.NombreDeUsuario;
                bool sitioDistinto = par.Sitio != parAChequear.Sitio;
                if (par.Contrasena.Clave == parAChequear.Contrasena.Clave && nombreDistinto && sitioDistinto)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
