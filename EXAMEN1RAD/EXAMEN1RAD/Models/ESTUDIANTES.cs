using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EXAMEN1RAD.Models
{
    public class ESTUDIANTES
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        
        [MaxLength(100)]
        public string nombres { get; set; }
       
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [NotNull, Unique]
        public string telefono { get; set; }

        [NotNull]
        public DateTime EDAD { get; set; }


        
    }
}
