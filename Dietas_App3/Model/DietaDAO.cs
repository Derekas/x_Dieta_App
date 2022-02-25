using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.Model
{
    class DietaDAO
    {
        static public Task<List<Dieta>> GetAllAsync()
        {
            return DataBase.ConnectionDatabase.GetAllWithChildrenAsync<Dieta>();
        }
        static public Task AñadirUsuarioAsync(Dieta dieta)
        {
            return DataBase.ConnectionDatabase.InsertWithChildrenAsync(dieta, true);

        }
        static public Task ModificarUsuarioAsync(Dieta dieta)
        {
            return DataBase.ConnectionDatabase.InsertOrReplaceWithChildrenAsync(dieta);

        }

        public static void InsertTestDieta()
        {
            if (GetAllAsync().Result.Count==0)
            {
                List<Dieta> dietas = new List<Dieta>();

                Comida comida1 = new Comida("Albondigas", "1 racion (140g)", 285, 10.6, 17.3, 18.4, 0, "Comida");
                Comida comida2 = new Comida("Arroz integral", "1 tazon(185g)", 670, 44.4, 5, 1.7, 0, "Comida");
                Comida comida3 = new Comida("Cordero", "1 porcion(200g)", 340, 0, 24, 18.2, 0, "Cena");
                Comida comida4 = new Comida("Canelones", "5 piezas(290g)", 445, 41.9, 15.5, 15.7, 0, "Comida");
                Comida comida5 = new Comida("Chuleta de cerdo", "2 piezas (262g)", 590, 0.48, 6.25, 25.4, 0, "Cena");
                Comida comida6 = new Comida("Ensalada cesar", "1 racio(309g)", 392, 7, 5.4, 15.3, 0, "Comida");
                Comida comida7 = new Comida("Gazpacho", "1 racion(350g)", 180, 16.4, 2.2, 8, 0, "Cena");
                Comida comida8 = new Comida("Hummus", "1 racion(246g)", 435, 40.2, 9.7, 17.2, 0, "Almuerzo");
                Comida comida9 = new Comida("Kebab", "1 rollo (360g)", 774, 77, 37.9, 16.6, 0, "Cena");
                Comida comida10 = new Comida("Lasaña", "1 porcion(215g)", 284, 35.4, 20.5, 12.4, 0, "Comida");
                Comida comida11 = new Comida("Paella", "1 racion(400g)", 624, 81, 19, 21, 0, "Comida");
                Comida comida12 = new Comida("Pollo al horno", "2 pechugas(344g)", 564, 0, 32.8, 8.5, 0, "Cena");

                dietas.Add(new Dieta("Hipocalorica", 1200, 500, 70, 50));
                dietas[0].comidas = new List<Comida>();
                dietas[0].comidas.Add(comida1);
                dietas[0].comidas.Add(comida2);
                dietas[0].comidas.Add(comida3);
                dietas[0].comidas.Add(comida4);
                dietas[0].comidas.Add(comida5);
                dietas.Add(new Dieta("Musculo", 2000, 700, 80, 80));
                dietas[1].comidas = new List<Comida>();
                dietas[1].comidas.Add(comida6);
                dietas[1].comidas.Add(comida7);
                dietas[1].comidas.Add(comida8);
                dietas[1].comidas.Add(comida9);
                dietas[1].comidas.Add(comida10);

                dietas.Add(new Dieta("Mantenerse", 1500, 600, 50, 50));
                dietas[2].comidas = new List<Comida>();
                dietas[2].comidas.Add(comida11);
                dietas[2].comidas.Add(comida12);

                DataBase.ConnectionDatabase.InsertAllWithChildrenAsync(dietas, true).Wait();

            }

        }
    }
}
