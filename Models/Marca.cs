using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProyectoFinalProgramacion4.Models
{
    [Table("marca")]
    public class Marca
    {
        [PrimaryKey, AutoIncrement]
        public int IdMarca { get; set; }
        [MaxLength(250), Unique]
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        //public Marca()
        //{
        //}

        //public Marca(string descripcion, bool activo)
        //{
        //    Descripcion = descripcion;
        //    Activo = activo;
        //}
    }
}
