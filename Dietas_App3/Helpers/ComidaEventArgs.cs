using Dietas_App3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Helpers
{
    public class ComidaEventArgs : EventArgs
    {
        public ComidaEventArgs(Comida comida)
        {
            Comida = comida;
        }

        public Comida Comida { get; set; }
    }
}
