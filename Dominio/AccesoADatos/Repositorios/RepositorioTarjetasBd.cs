using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class RepositorioTarjetasBd : IRepositorioTarjetaDeCredito<TarjetaDeCredito>
    {
        public RepositorioTarjetasBd()
        {

        }

        public void Agregar(TarjetaDeCredito tarjetaAAgregar, string nombreCategoria)
        {
            using (var contexto = new ContextoGestorBd())
            {
                if (contexto.Tarjetas.Any(tarjeta => tarjeta.Codigo == tarjetaAAgregar.Codigo)
                || contexto.Categorias.Any(tarjeta => tarjeta.Id == tarjetaAAgregar.Id))
                {
                    throw new ExcepcionTarjetaDeCreditoYaExistente();
                }
                if (ContieneTarjeta(DarColeccion(), tarjetaAAgregar.Codigo))
                {
                    throw new ExcepcionTarjetaDeCreditoYaExistente();
                }
                EntidadTarjetaDeCredito entidadTarjetaDeCredito = ConvertirAEntidadTarjeta(tarjetaAAgregar);
                entidadTarjetaDeCredito.Categoria = contexto.Categorias.FirstOrDefault(categoria => categoria.Nombre == nombreCategoria);
                contexto.Tarjetas.Add(entidadTarjetaDeCredito);
                contexto.SaveChanges();
                tarjetaAAgregar.Id = entidadTarjetaDeCredito.Id;
            }
            
        }

        public int Contar()
        {
            int cantidad = 0;
            using (ContextoGestorBd contexto = new ContextoGestorBd())
            {
                cantidad = contexto.Tarjetas.Count();
            }
            return cantidad;
        }

        public ICollection<TarjetaDeCredito> DarColeccion()
        {
            List<EntidadTarjetaDeCredito> listaEntidadesTarjetas = null;
            using (var contexto = new ContextoGestorBd())
            {
                listaEntidadesTarjetas = contexto.Tarjetas.Include("Categoria").ToList();
                
            }
            ICollection<TarjetaDeCredito> tarjetas = new List<TarjetaDeCredito>();
            foreach (EntidadTarjetaDeCredito entidadTarjeta in listaEntidadesTarjetas)
            {
                if (!entidadTarjeta.EstaBorrada)
                {
                    tarjetas.Add(ConvertirAObjetoTarjeta(entidadTarjeta));
                }
            }
            return tarjetas;
        }

        public void EditarNombre(string codigoTarjetaDeCredito, string nuevoNombre)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadEncontrada = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigoTarjetaDeCredito);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteTarjetaDeCredito();
                }
                entidadEncontrada.Nombre = nuevoNombre;
                contexto.SaveChanges();
            }
        }

        public void EditarTipo(string codigoTarjetaDeCredito, string nuevoTipo)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadEncontrada = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigoTarjetaDeCredito);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteTarjetaDeCredito();
                }
                entidadEncontrada.Tipo = nuevoTipo;
                contexto.SaveChanges();
            }
        }

        public void EditarCodigo(string codigoTarjetaDeCredito, string nuevoCodigo)
        {
            using (var contexto = new ContextoGestorBd())
            {
                if (ContieneTarjeta(DarColeccion(), nuevoCodigo))
                {
                    throw new ExcepcionTarjetaDeCreditoYaExistente();
                }
                EntidadTarjetaDeCredito entidadEncontrada = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigoTarjetaDeCredito);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteTarjetaDeCredito();
                }
                entidadEncontrada.Codigo = nuevoCodigo;
                contexto.SaveChanges();
            }
        }

        public void EditarCodigoDeSeguridad(string codigoTarjetaDeCredito, string nuevoCodigoDeSeguridad)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadEncontrada = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigoTarjetaDeCredito);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteTarjetaDeCredito();
                }

                entidadEncontrada.CodigoDeSeguridad = nuevoCodigoDeSeguridad;
                contexto.SaveChanges();
            }
        }

        public void EditarVencimiento(string codigoTarjetaDeCredito, string nuevoVencimiento)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadEncontrada = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigoTarjetaDeCredito);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteTarjetaDeCredito();
                }

                entidadEncontrada.FechaVencimiento = nuevoVencimiento;
                contexto.SaveChanges();
            }
        }

        public TarjetaDeCredito Obtener(string codigo, string nombreCategoria)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito tarjetaDeCredito = contexto.Tarjetas.FirstOrDefault(tarjeta => tarjeta.Codigo == codigo);
                if (tarjetaDeCredito == null)
                {
                    throw new ExcepcionNoExisteCategoria();
                }
                return ConvertirAObjetoTarjeta(tarjetaDeCredito);
            }
        }

        public void Eliminar(TarjetaDeCredito tarjeta)
        {

            using (var contexto = new ContextoGestorBd())
            {
                EntidadTarjetaDeCredito entidadAEliminar = contexto.Tarjetas.Include("Categoria").FirstOrDefault
                (tarj => tarj.Codigo == tarjeta.Codigo);
                entidadAEliminar.EstaBorrada = true;
                contexto.SaveChanges();
            }
        }

        private EntidadTarjetaDeCredito ConvertirAEntidadTarjeta(TarjetaDeCredito tarjeta)
        {
            EntidadTarjetaDeCredito entidadTarjeta = new EntidadTarjetaDeCredito();
            entidadTarjeta.Id = tarjeta.Id;
            entidadTarjeta.Codigo = tarjeta.Codigo;
            entidadTarjeta.Nombre = tarjeta.Nombre;
            entidadTarjeta.Tipo = tarjeta.Tipo;
            entidadTarjeta.FechaVencimiento = tarjeta.FechaVencimiento;
            entidadTarjeta.CodigoDeSeguridad = tarjeta.CodigoDeSeguridad;
            entidadTarjeta.Nota = tarjeta.Nota;
            return entidadTarjeta;
        }

        private TarjetaDeCredito ConvertirAObjetoTarjeta(EntidadTarjetaDeCredito entidadTarjeta)
        {
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            tarjeta.Id = entidadTarjeta.Id;
            tarjeta.Codigo = entidadTarjeta.Codigo;
            tarjeta.Nombre = entidadTarjeta.Nombre;
            tarjeta.Tipo = entidadTarjeta.Tipo;
            tarjeta.Categoria = ObtenerObjetoCategoria(entidadTarjeta.Categoria.Id);
            tarjeta.CodigoDeSeguridad = entidadTarjeta.CodigoDeSeguridad;
            tarjeta.FechaVencimiento = entidadTarjeta.FechaVencimiento;
            tarjeta.Nota = entidadTarjeta.Nota;
            return tarjeta;
        }

        private Categoria ObtenerObjetoCategoria(int id)
        {
            using (var contexto = new ContextoGestorBd())
            {
                EntidadCategoria entidadEncontrada = contexto.Categorias.FirstOrDefault(categoria => categoria.Id == id);
                if (entidadEncontrada == null)
                {
                    throw new ExcepcionNoExisteCategoria();
                }
                return ConvertirAObjetoCategoria(entidadEncontrada);
            }
        }

        private Categoria ConvertirAObjetoCategoria(EntidadCategoria entidadCategoria)
        {
            Categoria categoria = new Categoria(entidadCategoria.Nombre);
            categoria.Id = entidadCategoria.Id;
            return categoria;
        }

        private bool ContieneTarjeta(ICollection<TarjetaDeCredito> tarjetas, string codigoTarjeta)
        {
            TarjetaDeCredito tarjetaParaBuscar = tarjetas.FirstOrDefault(t => t.Codigo == codigoTarjeta);
            if (tarjetaParaBuscar == null)
            {
                return false;
            }
            return true;
        }
    }
}



