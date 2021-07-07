using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class ManejadorUsuarioBd : IManejadorUsuario<Usuario, ContrasenaMaestra>
    {
        public void PersistirUsuario(Usuario unUsuario)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                EntidadUsuario entidadAAgregar = new EntidadUsuario();
                entidadAAgregar = ConvertirAEntidadUsuario(unUsuario);
                entidadAAgregar.ConstrasenaMaestra = ConvertirAEntidadContrasenaMaestra(unUsuario.ContrasenaMaestra);
                unUsuario.Id = entidadAAgregar.Id;
                contexto.Usuarios.Add(entidadAAgregar);
                contexto.SaveChanges();
            }
        }

        public Usuario ObtenerUsuario()
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                ICollection<EntidadUsuario> listaUsuarios = contexto.Usuarios.Include("ConstrasenaMaestra").ToList();
                EntidadUsuario entidad = listaUsuarios.ElementAt(0);
                return ConvertirAObjetoUsuario(entidad);
            }
        }

        public void CambiarContrasenaMaestra(ContrasenaMaestra ContrasenaAnterior, ContrasenaMaestra contrasenaNueva)
        {
            Usuario usuarioPersistido = ObtenerUsuario();
            string claveDelUsuario = usuarioPersistido.ContrasenaMaestra.Clave;
            if (claveDelUsuario == ContrasenaAnterior.Clave)
            {
                usuarioPersistido.ContrasenaMaestra = contrasenaNueva;
            }
            else
            {
                throw new ExcepcionContrasenaNoCoincidente();
            }
            ActualizarContrasenaUsuario(usuarioPersistido);
        }

        public bool UsuarioYaPersistido()
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                return contexto.Usuarios.Count() > 0;
            }
        }

        private EntidadUsuario ConvertirAEntidadUsuario(Usuario usuario)
        {
            EntidadUsuario entidadARetornar = new EntidadUsuario();
            entidadARetornar.Id = usuario.Id;
            entidadARetornar.ConstrasenaMaestra = ConvertirAEntidadContrasenaMaestra(usuario.ContrasenaMaestra);
            return entidadARetornar;
        }

        private void ActualizarContrasenaUsuario(Usuario unUsuario)
        {
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                foreach (EntidadContrasenaMaestra contrasena in contexto.ContrasenaMaestras)
                {
                    contexto.ContrasenaMaestras.Attach(contrasena);
                    contexto.ContrasenaMaestras.Remove(contrasena);
                }

                foreach (EntidadUsuario entidad in contexto.Usuarios)
                {
                    contexto.Usuarios.Attach(entidad);
                    contexto.Usuarios.Remove(entidad);
                }
                EntidadUsuario usuarioNuevosDatos = ConvertirAEntidadUsuario(unUsuario);
             
                contexto.Usuarios.Add(usuarioNuevosDatos);
                contexto.SaveChanges();
            }
        }

        private EntidadContrasenaMaestra ConvertirAEntidadContrasenaMaestra(ContrasenaMaestra contrasena)
        {
            EntidadContrasenaMaestra entidadARetornar = new EntidadContrasenaMaestra();
            entidadARetornar.Id = contrasena.Id;
            entidadARetornar.Clave = contrasena.Clave;
            return entidadARetornar;
        }

        private Usuario ConvertirAObjetoUsuario(EntidadUsuario entidad)
        {
            Usuario usuario = new Usuario();
            usuario.Id = entidad.Id;
            usuario.ContrasenaMaestra = ConvertirAObjetoContrasenaMaestra(entidad.ConstrasenaMaestra);
            return usuario;
        }

        private ContrasenaMaestra ConvertirAObjetoContrasenaMaestra(EntidadContrasenaMaestra entidad)
        {
            string clave = entidad.Clave;
            ContrasenaMaestra contrasena = new ContrasenaMaestra(clave);
            contrasena.Id = entidad.Id;
            return contrasena;
        }
    }
}
