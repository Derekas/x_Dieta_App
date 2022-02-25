 using Dietas_App3.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    public class DataBase
    {
        public static SQLiteAsyncConnection ConnectionDatabase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>();
        static DataBase()
        {
            /*ConnectionDatabase.DropTableAsync<Dieta>().Wait();
            ConnectionDatabase.DropTableAsync<Comida>().Wait();*/

            ConnectionDatabase.CreateTableAsync<Dieta>().Wait();
            ConnectionDatabase.CreateTableAsync<Comida>().Wait();
            //ConnectionDatabase.CreateTableAsync<Categoria>().Wait();
            ConnectionDatabase.CreateTableAsync<Usuario>().Wait();
            ConnectionDatabase.CreateTableAsync<DietasComidas>().Wait();

<<<<<<< HEAD
            //DietaDAO.InsertTestDieta();

=======
>>>>>>> 8b3bb39310e2115cefb951a1f3420fee380d7bae
        }
    }
}
