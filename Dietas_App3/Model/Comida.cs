using Dietas_App3.Utils;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Comida")]
    public class Comida : NotifyPropertyBase
    {
        [PrimaryKey]
        public int id { get; set; }
        private String _nom;
        public String Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                OnPropertyChanged();
            }
        }

<<<<<<< HEAD
        public String Cantidad { get; set; }
        public double Calorias { get; set; }
        public double Hidratos { get; set; }
        public double Proteina { get; set; }
        public double Grasas { get; set; }

        public int DiaSemana { get; set; }
        [ManyToMany(typeof(DietasComidas),CascadeOperations=CascadeOperation.All)]
        public List<Dieta> dietas { get; set; }

        public String Categoria { get; set; }

        [Ignore]
        public ObservableCollection<Comida> Desayuno { get; set; }
        
        public Comida()
        {

        }

        public Comida(String nom,String cantidad,double calorias,double hidratos,double proteina,double grasas,int diasemana,String categoria)
        {
            Nom = nom;
            Cantidad = cantidad;
            Calorias = calorias;
            Hidratos = hidratos;
            Proteina = proteina;
            Grasas = grasas;
            DiaSemana = diasemana;
            Categoria = categoria;

        }
=======
        public String cantidad { get; set; }
        public double calorias { get; set; }
        public double hidratos { get; set; }
        public double proteina { get; set; }
        public double grasas { get; set; }

        public int diaSemana { get; set; }
        [ManyToMany(typeof(DietasComidas))]
        public List<Dieta> dietas { get; set; }

        public String categoria { get; set; }
        [Ignore]
        public ObservableCollection<Comida> Desayuno { get; set; }

>>>>>>> 8b3bb39310e2115cefb951a1f3420fee380d7bae
    }

}
