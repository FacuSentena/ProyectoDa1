using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class ExcepcionContrasenaNoCoincidente : Exception
    {
        public ExcepcionContrasenaNoCoincidente()
        {

        }
    }
}