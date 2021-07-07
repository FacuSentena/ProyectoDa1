using System.Collections.Generic;

namespace Dominio
{
    public interface IRepositorioTarjetaDeCredito<T>
    {
        void Agregar(T objetoAAgregar,string NombreCategoria);

        ICollection<T> DarColeccion();

        T Obtener(string codigoTarjeta, string nombreCategoria);

        void EditarNombre(string codigoTarjeta, string nuevoNombre);

        void EditarTipo(string codigoTarjeta, string nuevoTipo);

        void EditarCodigo(string codigoTarjeta, string nuevoCodigo);

        void EditarCodigoDeSeguridad(string codigoTarjeta, string nuevoCodigoDeSeguridad);

        void EditarVencimiento(string codigoTarjeta, string nuevoVencimiento);

        int Contar();

        void Eliminar(TarjetaDeCredito tarjeta);
    }
}
