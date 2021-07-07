using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria : IComparable
    {
        public int Id { get; set; }

        public string Nombre { set; get; }

        private List<TarjetaDeCredito> TarjetasDeCredito;

        private List<ParUsuarioContrasena> ParesUsuarioContrasenas;

        public Categoria(string unNombre)
        {
            if (this.NombreCateogriaValido(unNombre))
            {
                this.Nombre = unNombre;
                this.TarjetasDeCredito = new List<TarjetaDeCredito>();
                this.ParesUsuarioContrasenas = new List<ParUsuarioContrasena>();
            }
            else
            {
                throw new ExcepcionCategoriaNombreInvalido();
            }
        }

        public void ModificarNombre(string unNombre)
        {
            if (this.NombreCateogriaValido(unNombre))
            {
                this.Nombre = unNombre;
            }
            else
            {
                throw new ExcepcionCategoriaNombreInvalido();
            }
        }

        private bool NombreCateogriaValido(string unNombre)
        {
            return unNombre.Length > 3 && unNombre.Length < 15;
        }

        public bool TieneTarjetasDeCredito()
        {
            return this.TarjetasDeCredito.Count != 0;
        }

        public int ContarTarjetasDeCredito()
        {
            return this.TarjetasDeCredito.Count;
        }

        public void AgregarTarjetaDeCredito(TarjetaDeCredito tarjetaDeCredito)
        {
            if (!this.TarjetasDeCredito.Contains(tarjetaDeCredito))
            {
                this.TarjetasDeCredito.Add(tarjetaDeCredito);
            }
            else
            {
                throw new ExcepcionTarjetaDeCreditoYaExistente();
            }
        }

        public TarjetaDeCredito ObtenerTarjetaDeCredito(string nombreTarjetaDeCredito)
        {
            TarjetaDeCredito tarjetaDeCreditoAObtener = TarjetasDeCredito.FirstOrDefault(c => c.Nombre == nombreTarjetaDeCredito);
            if (tarjetaDeCreditoAObtener == null)
            {
                throw new ExcepcionNoExisteTarjetaDeCredito();
            }
            return tarjetaDeCreditoAObtener;
        }

        public void EliminarTarjetaDeCredito(TarjetaDeCredito unaTarjetaDeCredito)
        {
            if (this.TarjetasDeCredito.Contains(unaTarjetaDeCredito))
            {
                this.TarjetasDeCredito.Remove(unaTarjetaDeCredito);
            }
        }

        public bool TieneParesUsuarioContrasena()
        {
            return this.ParesUsuarioContrasenas.Count != 0;
        }

        public int ContarParUsuarioContrasena()
        {
            return this.ParesUsuarioContrasenas.Count;
        }

        public void AgregarParUsuarioContrasena(ParUsuarioContrasena parUsuarioContrasena)
        {
            if (!this.ParesUsuarioContrasenas.Contains(parUsuarioContrasena))
            {
                this.ParesUsuarioContrasenas.Add(parUsuarioContrasena);
            }
            else
            {
                throw new ExcepcionParUsuarioContrasenaYaExistente();
            }
        }

        public ParUsuarioContrasena ObtenerParUsuarioContrasenaPorUsuarioYSitio(string nombre, string sitio)
        {
            ParUsuarioContrasena parARetornar = new ParUsuarioContrasena();
            foreach (ParUsuarioContrasena par in ParesUsuarioContrasenas)
            {
                if (par.Sitio == sitio && par.NombreDeUsuario == nombre)
                {
                    parARetornar = par;
                }
            }
            return parARetornar;
        }

        public void EliminarParUsuarioContrasena(ParUsuarioContrasena par)
        {
            if (this.ParesUsuarioContrasenas.Contains(par))
            {
                this.ParesUsuarioContrasenas.Remove(par);
            }
            else
            {
                throw new ExcepcionParUsuarioContrasenaNoExistente();
            }
        }

        public List<TarjetaDeCredito> DarTarjetasDeCredito()
        {
            return this.TarjetasDeCredito;
        }

        public ICollection<ParUsuarioContrasena> DarTodasLasContrasenas()
        {
            List<ParUsuarioContrasena> paresUsuarioContrasena = new List<ParUsuarioContrasena>();
            foreach (ParUsuarioContrasena par in this.ParesUsuarioContrasenas)
            {
                ParUsuarioContrasena parUsuarioContrasenaAObtener = par;
                paresUsuarioContrasena.Add(parUsuarioContrasenaAObtener);
            }
            return paresUsuarioContrasena;
        }

        public int ContarContrasenasPorGrupo(string grupoDeFortaleza)
        {
            int cantidadDeContrasenasDelGrupo = 0;
            foreach (ParUsuarioContrasena par in this.ParesUsuarioContrasenas)
            {
                Contrasena contrasenaAObtener = par.Contrasena;
                if (contrasenaAObtener.GrupoDeFortaleza == grupoDeFortaleza)
                {
                    cantidadDeContrasenasDelGrupo++;
                }
            }
            return cantidadDeContrasenasDelGrupo;
        }

        public List<ParUsuarioContrasena> DarParesUsuarioContrasena(string grupoDeFortaleza)
        {
            List<ParUsuarioContrasena> pares = new List<ParUsuarioContrasena>();
            foreach (ParUsuarioContrasena par in this.ParesUsuarioContrasenas)
            {
                Contrasena contrasenaDelParAObtener = par.Contrasena;
                if (contrasenaDelParAObtener.GrupoDeFortaleza == grupoDeFortaleza)
                {
                    pares.Add(par);
                }
            }
            return pares;
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else
            {
                Categoria categoria = obj as Categoria;
                return this.Nombre.CompareTo(categoria.Nombre);
            }
        }

        public override bool Equals(object obj)
        {
            Categoria categoria = obj as Categoria;

            if (categoria == null) return false;

            return this.Nombre.ToUpper().Equals(categoria.Nombre.ToUpper());
        }
    }
}