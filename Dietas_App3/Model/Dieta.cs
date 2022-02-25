using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Dieta")]
    public class Dieta
    {
        [PrimaryKey]
        public int id { get; set; }
<<<<<<< HEAD
        public String Nom { get; set; }
        public int Calorias_Limite { get; set; }
        public int Hidratos_Limite { get; set; }
        public int Proteina_Limite { get; set; }
        public int Grasas_Limite { get; set; }

        [ManyToMany(typeof(DietasComidas),CascadeOperations =CascadeOperation.All)]
        public List<Comida> comidas { get; set; }

        [ForeignKey(typeof(Usuario))]
        public int UsuarioID { get; set; }


        public Dieta()
        {

        }

        public Dieta(String nom, int calorias_limite, int hidratos_limite, int proteina_limite, int grasas_limite)
        {
            Nom = nom;
            Calorias_Limite = calorias_limite;
            Hidratos_Limite = hidratos_limite;
            Proteina_Limite = proteina_limite;
            Grasas_Limite = grasas_limite;

        }
=======
        public String nom { get; set; }
        public double calorias_Limite { get; set; }
        public double hidratos_Limite { get; set; }
        public double proteina_Limite { get; set; }
        public double grasas_Limite { get; set; }

        [ManyToMany(typeof(DietasComidas))]
        public List<Comida> comidas { get; set; }

>>>>>>> 8b3bb39310e2115cefb951a1f3420fee380d7bae
    }

}