using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.Model
{
    class UsuarioDAO
    {
        static public Task<List<Usuario>> GetAllAsync()
        {
            return DataBase.ConnectionDatabase.GetAllWithChildrenAsync<Usuario>();
        }
        static public Task AñadirUsuarioAsync(Usuario usu)
        {
            return DataBase.ConnectionDatabase.InsertWithChildrenAsync(usu, true);
            
        }
        static public Task ModificarUsuarioAsync(Usuario usu)
        {
            return DataBase.ConnectionDatabase.InsertOrReplaceWithChildrenAsync(usu);

        }
    }
}
