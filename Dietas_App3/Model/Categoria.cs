using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Dietas_App3.Model
{
    [Table("Categoria")]
    public class Categoria
    {
        [PrimaryKey]
        public int id { get; set; }
        public string nom { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Comida> comidas { get; set; }
    }
}