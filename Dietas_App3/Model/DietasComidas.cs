using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
<<<<<<< HEAD
 
        [Table("DietasComida")]
        public class DietasComidas
        {
            [ForeignKey(typeof(Comida))]
            public int ComidaId { get; set; }

            [ForeignKey(typeof(Dieta))]
            public int DietaId { get; set; }

        }

    
=======
    [Table("DietasComida")]
    public class DietasComidas
    {
        [ForeignKey(typeof(Comida))]
        public int ComidaId { get; set; }

        [ForeignKey(typeof(Dieta))]
        public int DietaId { get; set; }

    }
>>>>>>> 8b3bb39310e2115cefb951a1f3420fee380d7bae
}
