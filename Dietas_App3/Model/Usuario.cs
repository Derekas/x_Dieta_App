using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public double Peso { get; set; }
        public int Edad { get; set; }
        public double Altura { get; set; }
        public String Sexo { get; set; }
        public String Actividad { get; set; }
        [OneToMany]
        public List<Dieta> Dietas { get; set; }

        public Usuario()
        {

        }

        public Usuario(double peso, int edad, double altura, String sexo, String actividad)
        {
            Peso = peso;
            Edad = edad;
            Altura = altura;
            Sexo = sexo;
            Actividad= actividad;
            
        }

    }
}
