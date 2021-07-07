using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class GeneradorDeClave 
    {
        public int LargoDeLaContrasena { get; set; }
        public bool MayusculasSeleccionado { get; set; }
        public bool MinusculasSeleccionado { get; set; }
        public bool SimbolosSeleccionado { get; set; }
        public bool NumerosSeleccionado { get; set; }

        public Contrasena GenerarContrasenaEnBaseASeleccionados()
        {
            int largo =(LargoDeLaContrasena);
            bool mayusculasSeleccionado = MayusculasSeleccionado;
            bool simbolosSeleccionado = SimbolosSeleccionado;
            bool minusculasSeleccionado = MinusculasSeleccionado;
            bool digitosSeleccionado = NumerosSeleccionado;
            Contrasena contrasena = new Contrasena();
            try
            {
                if (mayusculasSeleccionado && !simbolosSeleccionado && !minusculasSeleccionado && !digitosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculas(largo);
                }
                else if (minusculasSeleccionado && !simbolosSeleccionado && !mayusculasSeleccionado && !digitosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMinusculas(largo);
                }
                else if (simbolosSeleccionado && !minusculasSeleccionado && !mayusculasSeleccionado && !digitosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveSimbolos(largo);
                }
                else if (digitosSeleccionado && !minusculasSeleccionado && !mayusculasSeleccionado && !simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveNumeros(largo);
                }
                else if (minusculasSeleccionado && mayusculasSeleccionado && !digitosSeleccionado && !simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasYMinusculas(largo);
                }
                else if (minusculasSeleccionado && !mayusculasSeleccionado && digitosSeleccionado && !simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMinusculasYNumeros(largo);
                }
                else if (minusculasSeleccionado && !mayusculasSeleccionado && !digitosSeleccionado && simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMinusculasYSimbolos(largo);
                }
                else if (!minusculasSeleccionado && mayusculasSeleccionado && digitosSeleccionado && !simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasYNumeros(largo);
                }
                else if (!minusculasSeleccionado && mayusculasSeleccionado && !digitosSeleccionado && simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasYSimbolos(largo);
                }
                else if (!minusculasSeleccionado && !mayusculasSeleccionado && digitosSeleccionado && simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveNumerosYSimbolos(largo);
                }
                else if (minusculasSeleccionado && mayusculasSeleccionado && !digitosSeleccionado && simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasYSimbolos(largo);
                }
                else if (minusculasSeleccionado && mayusculasSeleccionado && digitosSeleccionado && !simbolosSeleccionado)
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasYNumeros(largo);
                }
                else
                {
                    contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasNumerosYSimbolos(largo);
                }
            }
            catch (ExepcionContrasenaInvalida)
            {

            }
            contrasena.AsignarGrupoDeFortaleza();
            contrasena.UltimaModificacion = DateTime.Now;
            return contrasena;
        }
    }

}
