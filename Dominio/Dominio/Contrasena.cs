using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contrasena
    {
        public int Id { get; set; }

        public string Clave { get; set; }

        public string GrupoDeFortaleza { get; set; }

        public DateTime UltimaModificacion { get; set; }

        public Contrasena()
        {

        }

        public Contrasena(string unaClave)
        {
            if (LargoValido(unaClave))
            {
                this.Clave = unaClave;
                this.GrupoDeFortaleza = AsignarGrupoDeFortaleza();
                this.UltimaModificacion = DateTime.Now;
            }
            else
            {
                throw new ExepcionContrasenaInvalida();
            }
        }

        public void CambiarClave(string unaClave)
        {
            if (LargoValido(unaClave))
            {
                this.Clave = unaClave;
                this.GrupoDeFortaleza = AsignarGrupoDeFortaleza();
                this.UltimaModificacion = DateTime.Now;
            }
            else
            {
                throw new ExepcionContrasenaInvalida();
            }
        }

        private bool LargoValido(string unaClave)
        {
            return unaClave.Length > 4 && unaClave.Length < 26;
        }

        public string GenerarClaveMayusculas(int largoClave)
        {
            char[] claveGenerada = GenerarClaveBase(largoClave);
            int valorASCIIminimoMayuscula = 65;
            int valorASCIImaximoMayuscula = 90;
            Random numeroAleatorio = new Random();
            for (int posicion = 0; posicion < largoClave; posicion++)
            {
                int valorAsciAleatorio = numeroAleatorio.Next(valorASCIIminimoMayuscula, valorASCIImaximoMayuscula);
                claveGenerada[posicion] = Convert.ToChar(valorAsciAleatorio);
            }
            string claveMayusculas = new string(claveGenerada);
            return claveMayusculas;
        }

        public string GenerarClaveSimbolos(int largoClave)
        {
            string simbolos = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            int largoSimbolos = simbolos.Length;
            char[] claveGenerada = GenerarClaveBase(largoClave);
            Random numeroAleatorio = new Random();
            for (int posicion = 0; posicion < largoClave; posicion++)
            {
                int posicionSimbolos = numeroAleatorio.Next(1, largoSimbolos);
                claveGenerada[posicion] = simbolos[posicionSimbolos];
            }
            string claveSimbolos = new string(claveGenerada);
            return claveSimbolos;
        }

        public string GenerarClaveNumeros(int largoClave)
        {
            char[] claveGenerada = GenerarClaveBase(largoClave);
            int valorASCIIminimoNumero = 48;
            int valorASCIImaximoNumero = 57;
            Random numeroAleatorio = new Random();
            for (int posicion = 0; posicion < largoClave; posicion++)
            {
                int valorAsciAleatorio = numeroAleatorio.Next(valorASCIIminimoNumero, valorASCIImaximoNumero);
                claveGenerada[posicion] = Convert.ToChar(valorAsciAleatorio);
            }
            string claveMayusculas = new string(claveGenerada);
            return claveMayusculas;
        }

        public string GenerarClaveMinusculas(int largoClave)
        {
            char[] claveGenerada = GenerarClaveBase(largoClave);
            int valorASCIIminimoMinuscula = 97;
            int valorASCIImaximoMinuscula = 122;
            Random numeroAleatorio = new Random();
            for (int posicion = 0; posicion < largoClave; posicion++)
            {
                int valorAsciAleatorio = numeroAleatorio.Next(valorASCIIminimoMinuscula, valorASCIImaximoMinuscula);
                claveGenerada[posicion] = Convert.ToChar(valorAsciAleatorio);
            }
            string claveMayusculas = new string(claveGenerada);
            return claveMayusculas;
        }

        public string GenerarClaveMayusculasYMinusculas(int largoClave)
        {
            string parteClaveMinusculas = GenerarClaveMinusculas(largoClave - 2);
            string claveMayusculasYMinusculasOrdenada = parteClaveMinusculas + GenerarClaveMayusculas(2);
            string claveMayusculasYMinusculasGenerada = MezclarCaracteres(claveMayusculasYMinusculasOrdenada);
            return claveMayusculasYMinusculasGenerada;
        }

        public string GenerarClaveMayusculasYSimbolos(int largoClave)
        {
            string parteClaveMayusculas = GenerarClaveMayusculas(largoClave - 2);
            string claveMayusculasYSimbolosOrdenada = parteClaveMayusculas + GenerarClaveSimbolos(2);
            string claveMayusculasYSimbolosGenerada = MezclarCaracteres(claveMayusculasYSimbolosOrdenada);
            return claveMayusculasYSimbolosGenerada;
        }

        public string GenerarClaveMayusculasYNumeros(int largoClave)
        {
            string parteClaveMayusculas = GenerarClaveMayusculas(largoClave - 2);
            string claveMayusculasYNumerosOrdenada = parteClaveMayusculas + GenerarClaveNumeros(2);
            string claveMayusculasYNumerosGenerada = MezclarCaracteres(claveMayusculasYNumerosOrdenada);
            return claveMayusculasYNumerosGenerada;
        }

        public string GenerarClaveMinusculasYNumeros(int largoClave)
        {
            string parteClaveMinusculas = GenerarClaveMinusculas(largoClave - 2);
            string claveMinusculasYNumerosOrdenada = parteClaveMinusculas + GenerarClaveNumeros(2);
            string claveMinusculasYNumerosGenerada = MezclarCaracteres(claveMinusculasYNumerosOrdenada);
            return claveMinusculasYNumerosGenerada;
        }

        public string GenerarClaveMinusculasYSimbolos(int largoClave)
        {
            string parteClaveMinusculas = GenerarClaveMinusculas(largoClave - 2);
            string claveMinusculasYSimbolosOrdenada = parteClaveMinusculas + GenerarClaveSimbolos(2);
            string claveMinusculasYSimbolosGenerada = MezclarCaracteres(claveMinusculasYSimbolosOrdenada);
            return claveMinusculasYSimbolosGenerada;
        }

        public string GenerarClaveNumerosYSimbolos(int largoClave)
        {
            string parteClaveNumeros = GenerarClaveNumeros(largoClave - 2);
            string claveNumerosYSimbolosOrdenada = parteClaveNumeros + GenerarClaveSimbolos(2);
            string claveNumerosYSimbolosGenerada = MezclarCaracteres(claveNumerosYSimbolosOrdenada);
            return claveNumerosYSimbolosGenerada;
        }

        public string GenerarClaveMayusculasMinusculasYSimbolos(int largoClave)
        {
            string parteClaveMayusculaYMinuscula = GenerarClaveMayusculasYMinusculas(largoClave - 1);
            string claveMayusculaMinusculaYSimboloOrdenada = parteClaveMayusculaYMinuscula + GenerarClaveSimbolos(1);
            string claveMayusculaMinusculaYSimboloGenerada = MezclarCaracteres(claveMayusculaMinusculaYSimboloOrdenada);
            return claveMayusculaMinusculaYSimboloGenerada;
        }

        public string GenerarClaveMayusculasMinusculasYNumeros(int largoClave)
        {
            string parteClaveMayusculaYMinuscula = GenerarClaveMayusculasYMinusculas(largoClave - 1);
            string claveMayusculaMinusculaYNumerosOrdenada = parteClaveMayusculaYMinuscula + GenerarClaveNumeros(1);
            string claveMayusculaMinusculaYNumerosGenerada = MezclarCaracteres(claveMayusculaMinusculaYNumerosOrdenada);
            return claveMayusculaMinusculaYNumerosGenerada;
        }

        public string GenerarClaveMayusculasNumerosYSimbolos(int largoClave)
        {
            string parteClaveMayusculaYNumeros = GenerarClaveMayusculasYNumeros(largoClave - 1);
            string claveClaveMayusculasNumerosYSimbolosOrdenada = parteClaveMayusculaYNumeros + GenerarClaveSimbolos(1);
            string claveClaveMayusculasNumerosYSimbolosGenerada = MezclarCaracteres(claveClaveMayusculasNumerosYSimbolosOrdenada);
            return claveClaveMayusculasNumerosYSimbolosGenerada;
        }

        public string GenerarClaveMinusculasNumerosYSimbolos(int largoClave)
        {
            string parteClaveMinusculaYNumeros = GenerarClaveMinusculasYNumeros(largoClave - 1);
            string claveClaveMinusculasNumerosYSimbolosOrdenada = parteClaveMinusculaYNumeros + GenerarClaveSimbolos(1);
            string claveClaveMinusculasNumerosYSimbolosGenerada = MezclarCaracteres(claveClaveMinusculasNumerosYSimbolosOrdenada);
            return claveClaveMinusculasNumerosYSimbolosGenerada;
        }

        public string GenerarClaveMayusculasMinusculasNumerosYSimbolos(int largoClave)
        {
            string parteClaveMayusculaYMinuscula = GenerarClaveMayusculasYMinusculas(largoClave - 3);
            string claveMayusculasMinusculasNumerosYSimbolosOrdenada = parteClaveMayusculaYMinuscula + GenerarClaveNumerosYSimbolos(3);
            string claveMayusculasMinusculasNumerosYSimbolosGenerada = MezclarCaracteres(claveMayusculasMinusculasNumerosYSimbolosOrdenada);
            return claveMayusculasMinusculasNumerosYSimbolosGenerada;
        }

        private string MezclarCaracteres(string clave)
        {
            char[] claveDesordenada = clave.ToCharArray();
            Random random = new Random();
            int largoArray = claveDesordenada.Length;
            while (largoArray > 1)
            {
                largoArray--;
                int numeroRandom = random.Next(largoArray + 1);
                char caracter = claveDesordenada[numeroRandom];
                claveDesordenada[numeroRandom] = claveDesordenada[largoArray];
                claveDesordenada[largoArray] = caracter;
            }
            return new string(claveDesordenada);
        }

        private char[] GenerarClaveBase(int largoClave)
        {
            char[] arrayClaveBase = new char[largoClave];
            for (int posicion = 0; posicion < largoClave; posicion++)
            {
                arrayClaveBase[posicion] = 'A';
            }
            return arrayClaveBase;
        }

        public string AsignarGrupoDeFortaleza()
        {
            if (this.Clave.Length <= 8)
            {
                this.GrupoDeFortaleza = "Rojo";
                return "Rojo";

            }

            else if (this.Clave.Length > 8 && this.Clave.Length <=14)
            {
                this.GrupoDeFortaleza = "Naranja";
                return "Naranja";
            }

            else if (this.Clave.Length > 14 && TieneGrupoDeFortalezaVerdeOscuro(this.Clave))
            {
                this.GrupoDeFortaleza = "VerdeOscuro";
                return "VerdeOscuro";
            }

            else if (this.Clave.Length > 14 && TieneGrupoDeFortalezaVerdeClaro(this.Clave))
            {
                this.GrupoDeFortaleza = "VerdeClaro";
                return "VerdeClaro";
            }

            else if (this.Clave.Length > 14 && TieneGrupoDeFortalezaAmarillo(this.Clave))
            {
                this.GrupoDeFortaleza = "Amarillo";
                return "Amarillo";
            }

            return "";
        }

        private bool TieneGrupoDeFortalezaAmarillo(string clave)
        {
            bool valido = false;
            int cantidadMinusculas = ContarMinusculas(clave);
            int cantidadNumeros = ContarNumeros(clave);
            int cantidadMayusculas = ContarMayusculas(clave);
            int cantidadSimbolos = ContarSimbolos(clave);

            if (cantidadMayusculas == 0 && cantidadMinusculas == 0 && cantidadNumeros == 0 && cantidadSimbolos == 0)
            {
                valido = false;
            }
            else if (cantidadMayusculas > 0 && cantidadMinusculas > 0 && cantidadNumeros > 0 && cantidadSimbolos > 0)
            {
                valido = false;
            }
            else
            {
                valido = true;
            }

            return valido;
        }

        private bool TieneGrupoDeFortalezaVerdeClaro(string clave)
        {
            int cantidadMinusculas = ContarMinusculas(clave);
            int cantidadNumeros = ContarNumeros(clave);
            int cantidadMayusculas = ContarMayusculas(clave);
            int cantidadSimbolos = ContarSimbolos(clave);
            bool TieneMayusculaMinusculaYnumero = cantidadSimbolos == 0 && cantidadMayusculas > 0 && cantidadMinusculas > 0 && cantidadNumeros > 0;
            bool TieneMayusculaMinusculaYSimbolo = cantidadNumeros == 0 && cantidadMayusculas > 0 && cantidadMinusculas > 0 && cantidadSimbolos > 0;
            bool TieneMayusculaYminuscula = cantidadNumeros == 0 && cantidadMayusculas > 0 && cantidadMinusculas > 0 && cantidadSimbolos == 0;
            bool TieneNumeroMinusculaYSimbolo = cantidadNumeros > 0 && cantidadMayusculas == 0 && cantidadMinusculas > 0 && cantidadSimbolos > 0;
            bool TieneNumeroMayusculaYSimbolo = cantidadNumeros > 0 && cantidadMayusculas > 0 && cantidadMinusculas == 0 && cantidadSimbolos > 0;

            return TieneMayusculaMinusculaYnumero || TieneMayusculaMinusculaYSimbolo || TieneMayusculaYminuscula || TieneNumeroMinusculaYSimbolo
               || TieneNumeroMayusculaYSimbolo;
        }

        private bool TieneGrupoDeFortalezaVerdeOscuro(string clave)
        {
            int cantidadMinusculas = ContarMinusculas(clave);
            int cantidadNumeros = ContarNumeros(clave);
            int cantidadMayusculas = ContarMayusculas(clave);
            int cantidadSimbolos = ContarSimbolos(clave);
            return (cantidadSimbolos > 0 && cantidadMayusculas > 0 && cantidadMinusculas > 0 && cantidadNumeros > 0);
        }

        private int ContarMayusculas(string clave)
        {
            int cantidadMayusculas = 0;
            int valorASCIIminimoMayuscula = 65;
            int valorASCIImaximoMayuscula = 90;
            for (int posicion = 0; posicion < clave.Length; posicion++)
            {
                if (clave[posicion] >= valorASCIIminimoMayuscula && clave[posicion] <= valorASCIImaximoMayuscula)
                {
                    cantidadMayusculas++;
                }
            }
            return cantidadMayusculas;
        }

        private int ContarMinusculas(string clave)
        {
            int cantidadMinusculas = 0;
            int valorASCIIminimoMinuscula = 97;
            int valorASCIImaximoMinuscula = 122;
            for (int posicion = 0; posicion < clave.Length; posicion++)
            {
                if (clave[posicion] >= valorASCIIminimoMinuscula && clave[posicion] <= valorASCIImaximoMinuscula)
                {
                    cantidadMinusculas++;
                }
            }
            return cantidadMinusculas;
        }

        private int ContarNumeros(string clave)
        {
            int cantidadNumeros = 0;
            int valorASCIIminimoNumero = 48;
            int valorASCIImaximoNumero = 57;
            for (int posicion = 0; posicion < clave.Length; posicion++)
            {
                if (clave[posicion] >= valorASCIIminimoNumero && clave[posicion] <= valorASCIImaximoNumero)
                {
                    cantidadNumeros++;
                }
            }
            return cantidadNumeros;
        }

        private int ContarSimbolos(string clave)
        {
            int cantidadSimbolos = 0;
            int valorASCIIminimoSimboloPrimerRango = 33;
            int valorASCIImaximoSimboloPrimerRango = 47;
            int valorASCIIminimoSimboloSegundoRango = 58;
            int valorASCIImaximoSimboloSegundoRango = 64;
            int valorASCIIminimoSimboloTercerRango = 91;
            int valorASCIImaximoSimboloTercerRango = 96;
            int valorASCIIminimoSimboloCuartoRango = 123;
            int valorASCIImaximoSimboloCuartoRango = 126;
            for (int posicion = 0; posicion < clave.Length; posicion++)
            {
                if ((clave[posicion] >= valorASCIIminimoSimboloPrimerRango && clave[posicion] <= valorASCIImaximoSimboloPrimerRango) ||
                    (clave[posicion] >= valorASCIIminimoSimboloSegundoRango && clave[posicion] <= valorASCIImaximoSimboloSegundoRango) ||
                    (clave[posicion] >= valorASCIIminimoSimboloTercerRango && clave[posicion] <= valorASCIImaximoSimboloTercerRango) ||
                    (clave[posicion] >= valorASCIIminimoSimboloCuartoRango && clave[posicion] <= valorASCIImaximoSimboloCuartoRango))
                {
                    cantidadSimbolos++;
                }
            }
            return cantidadSimbolos;
        }

        public override bool Equals(object obj)
        {
            Contrasena contrasena = obj as Contrasena;

            if (contrasena == null) return false;

            return this.Clave.Equals(contrasena.Clave);
        }

        public override string ToString()
        {
            return " Id:" + this.Id + " Clave: " + this.Clave + " Modificacion: " + this.UltimaModificacion;
        }

    }
}
