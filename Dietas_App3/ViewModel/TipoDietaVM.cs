using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Dietas_App3.Model;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    class TipoDietaVM
    {
        public Usuario Usuario;
        public Boolean NuevoUsuario=true;
        public ObservableCollection<Usuario> Usuarios { get; set; }

        public TipoDietaVM()
        {
            //cogemos los datos de los usuarios desde usuario dao

            Usuarios = new ObservableCollection<Usuario>();
            if (Usuarios.Count > 0)
            {
                Usuario = Usuarios[0];
                NuevoUsuario = false;
            }
            else
            {
                Usuario = new Usuario();
            }
        }
        
        internal Boolean AñadirUsuario()
        {
            if (NuevoUsuario)
            {
                UsuarioDAO.AñadirUsuarioAsync(Usuario).Wait();
                NuevoUsuario = false;
                return true;
            }
            else
            {
                UsuarioDAO.ModificarUsuarioAsync(Usuario).Wait();
                return false;
            }

        }
    }
}
