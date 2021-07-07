using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        public ContrasenaMaestra ContrasenaMaestra { set; get; }

        private List<Categoria> categorias;

        public Usuario()
        {
            this.categorias = new List<Categoria>();
        }

        public Usuario(ContrasenaMaestra unaContrasenaMaestra)
        {
            this.ContrasenaMaestra = unaContrasenaMaestra;
        }

        public List<Categoria> ObtenerCategorias()
        {
            OrdenarCategorias();
            return this.categorias;
        }

        private void OrdenarCategorias()
        {
            this.categorias.Sort();
        }

        public bool TieneCategorias()
        {
            return this.categorias.Count != 0;
        }

        public int ContarCategorias()
        {
            return this.categorias.Count;
        }

        public Categoria ObtenerCategoria(string nombreCategoria)
        {
            OrdenarCategorias();
            Categoria cateogriaAObtener = categorias.FirstOrDefault(c => c.Nombre == nombreCategoria);
            if (cateogriaAObtener == null)
            {
                throw new ExcepcionNoExisteCategoria();
            }
            return cateogriaAObtener;
        }

        public bool ExisteCategoria(string nombreCategoria)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre == nombreCategoria)
                {
                    return true;
                }
            }
            return false;
        }

        public void AgregarCategoria(Categoria categoria)
        {
            if (!(this.categorias.Contains(categoria)))
            {
                this.categorias.Add(categoria);
            }
            else
            {
                throw new ExcepcionCategoriaYaExistente();
            }
        }

        public void CambiarClaveMaestra(ContrasenaMaestra contrasenaMaestraOriginal, ContrasenaMaestra nuevaContrasenaMaestra)
        {
            if (contrasenaMaestraOriginal.Clave==(this.ContrasenaMaestra.Clave))
            {
                this.ContrasenaMaestra = nuevaContrasenaMaestra;
            }
            else
            {
                throw new ExcepcionContrasenaNoCoincidente();
            }
        }

        public int ContarParesUsuarioContrasena()
        {
            return this.ObtenerParesUsuarioContrasena().Count;
        }

        public ICollection<ParUsuarioContrasena> ObtenerParesUsuarioContrasena()
        {
            ICollection<ParUsuarioContrasena> paresUsuarioContrasena = new List<ParUsuarioContrasena>();
            foreach (Categoria categoria in this.categorias)
            {
               ICollection<ParUsuarioContrasena> paresUsuarioContrasenaDeLaCategoria = categoria.DarTodasLasContrasenas();
                AgregarParesDeCategoria(paresUsuarioContrasena, paresUsuarioContrasenaDeLaCategoria);
            }
            return paresUsuarioContrasena;
        }

        public int ContarContrasenasPorGrupoDeFortaleza(string grupoDeFortaleza)
        {
            int cantidadDeContrasenasDelGrupo = 0;
            List<Contrasena> contrasenas = new List<Contrasena>();
            foreach (Categoria categoria in this.categorias)
            {
                cantidadDeContrasenasDelGrupo += categoria.ContarContrasenasPorGrupo(grupoDeFortaleza);
            }
            return cantidadDeContrasenasDelGrupo;
        }

        public List<ParUsuarioContrasena> ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza(string grupoDeFortaleza)
        {
            List<ParUsuarioContrasena> contrasenas = new List<ParUsuarioContrasena>();
            foreach (Categoria categoria in this.categorias)
            {
                List<ParUsuarioContrasena> listaDeParesDeLaCategoria = categoria.DarParesUsuarioContrasena(grupoDeFortaleza);
                AgregarParesDeCategoria(contrasenas, listaDeParesDeLaCategoria);
            }
            return contrasenas;
        }

        private void AgregarParesDeCategoria(ICollection<ParUsuarioContrasena> listaGeneralDePares, ICollection<ParUsuarioContrasena> paresDeUnaCategoria)
        {
            foreach (ParUsuarioContrasena par in paresDeUnaCategoria)
            {
                listaGeneralDePares.Add(par);
            }
        }

        public List<TarjetaDeCredito> ObtenerTarjetasDeCredito()
        {
            List<TarjetaDeCredito> tarjetas = new List<TarjetaDeCredito>();
            foreach (Categoria categoria in this.categorias)
            {
                AgregarTarjetasDeLaCategoria(tarjetas, categoria.DarTarjetasDeCredito());
            }
            return tarjetas;
        }

        private void AgregarTarjetasDeLaCategoria(List<TarjetaDeCredito> TarjetasAAgregar, List<TarjetaDeCredito> TarjetasDeLaCategoria)
        {
            foreach (TarjetaDeCredito tarjeta in TarjetasDeLaCategoria)
            {
                TarjetasAAgregar.Add(tarjeta);
            }
        }
    }
}
