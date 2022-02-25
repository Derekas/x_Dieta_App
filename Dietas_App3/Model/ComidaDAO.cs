using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensionsAsync.Extensions;
namespace Dietas_App3.Model
{
    public class ComidaDAO
    {
        
        static public Task<List<Comida>> GetAllAsync()
        {
            return DataBase.ConnectionDatabase.GetAllWithChildrenAsync<Comida>();
        }
        static public Task AñadirComidaAsync(Comida com)
        {
            return DataBase.ConnectionDatabase.InsertWithChildrenAsync(com, true);

        }
        static public Task ModificarComidaAsync(Comida com)
        {
            return DataBase.ConnectionDatabase.InsertOrReplaceWithChildrenAsync(com);

        }
    }
}
