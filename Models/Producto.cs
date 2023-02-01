using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProyectoFinalProgramacion4.Models
{
    [Table("producto")]
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        [MaxLength(250), Unique]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public bool Activo { get; set; }
        //public Marca oMarca { get; set; }
        //public Categoria oCategoria { get; set; }
    }
}
