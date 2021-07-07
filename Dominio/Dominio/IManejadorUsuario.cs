﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IManejadorUsuario<T,K>
    {
        void PersistirUsuario(T usuario);

        void CambiarContrasenaMaestra(K ContrasenaAnterior, K contrasenaNueva);

        T ObtenerUsuario();

        bool UsuarioYaPersistido();
    }
}
