using System.Collections.Generic;

namespace Dominio
{
    public interface IRepositorioCategorias<T>
    {
        void Agregar(T objetoAAgregar);

        ICollection<T> DarColeccion();

        T Obtener(string nombre);

        void Editar(string nombre, string nuevoNombre);

        int Contar();
    }
}