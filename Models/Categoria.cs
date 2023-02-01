using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProyectoFinalProgramacion4.Models
{
    [Table("categoria")]
    public class Categoria
    {
        [PrimaryKey, AutoIncrement]
        public int IdCategoria { get; set; }
        [MaxLength(250), Unique]
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        //public Categoria()
        //{
        //}

        //public Categoria(string descripcion, bool activo)
        //{
        //    Descripcion = descripcion;
        //    Activo = activo;
        //}
    }



}
