using Dietas_App3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Helpers
{
    public class UsuarioEventArgs: EventArgs
    {
        public UsuarioEventArgs(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Usuario Usuario { get; set; }
    }
}
