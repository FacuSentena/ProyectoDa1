using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorioParesUsuarioContrasena<T, K>
    {
        void Agregar(T unPar);

        ParUsuarioContrasena Obtener(string nombre, string sitio);

        int Contar();

        ICollection<ParUsuarioContrasena> DarColeccion();

        void Eliminar(string nombre, string sitio);

        void EditarNombreYSitio(T par, string nuevoNombre, string nuevoSitio);

        void EditarContrasena(string nombre, string sitio, K nuevaContrasena);

         ICollection<ParUsuarioContrasena> ObtenerParesPorGrupoDeSeguridad(string colorDeGrupoDeSeguriad);

        bool ContrasenaYaExistente(T parAChequear);
    }
}
