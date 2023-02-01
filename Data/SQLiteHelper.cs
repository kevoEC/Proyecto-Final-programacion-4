using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProyectoFinalProgramacion4.Models;
using System.Data;

namespace ProyectoFinalProgramacion4.Data
{
    public class SQLiteHelper
    {
        string _dbPath;
        private SQLiteConnection conn;
        public SQLiteHelper(string DatabasePath) {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Marca>();
            conn.CreateTable<Categoria>();
            conn.CreateTable<Producto>();
        }
        /*------------------CREACION MARCA------------------------*/
        public int AgregarMarca(Marca marca)
        {
            if (marca.IdMarca != 0)
                return conn.Update(marca);
            else
                return conn.Insert(marca);
        }

        public int RemoverMarca(Marca marca)
        {
            Init();
            return conn.Delete(marca);
        }

        public List<Marca> ObtenerTodasLasMarcas()
        {
            Init();
            List<Marca> marcas = conn.Table<Marca>().ToList();
            return marcas;
        }

        /*------------------CREACION CATEGORIA------------------------*/
        public int AgregarCategoria(Categoria categoria)
        {
            if (categoria.IdCategoria != 0)
                return conn.Update(categoria);
            else
                return conn.Insert(categoria);
        }

        public int RemoverCategoria(Categoria categoria)
        {
            Init();
            return conn.Delete(categoria);
        }

        public List<Categoria> ObtenerTodasLasCategorias()
        {
            Init();
            List<Categoria> categorias = conn.Table<Categoria>().ToList();
            return categorias;
        }
        /*------------------CREACION PRODUCTO------------------------*/
        public int AgregarProducto(Producto producto)
        {
            if (producto.IdProducto != 0)
                return conn.Update(producto);
            else
                return conn.Insert(producto);
        }

        public int RemoverProducto(Producto producto)
        {
            Init();
            return conn.Delete(producto);
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            Init();
            List<Producto> productos = conn.Table<Producto>().ToList();
            return productos;
        }
    }
}
