using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ8_MultipleJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Categoria> listaCategoria = new List<Categoria>
            {
                new Categoria { idCategoria=1, nombreCategoria="Fruta"},
                new Categoria { idCategoria=2, nombreCategoria="Verdura"}
            };

            List<Proveedor> listaProveedor = new List<Proveedor>
            {
                new Proveedor { idProveedor=1, nombre="ABC" },
                new Proveedor { idProveedor=2, nombre="CDE"}
            };

            List<Producto> listaProducto = new List<Producto>
            {
                new Producto{idProducto=1, nombre="Manguito clasico que bacaneria", idCategoria=1, idProveedor=2},
                new Producto{idProducto=2, nombre="Coles de bruselas", idCategoria=2, idProveedor=1}
            };

            // El producto es nombreProducto, su categoria es nombreCategoria y su proveedor es nombreProveedor
            var consulta = from producto in listaProducto
                           join categoria in listaCategoria
                           on producto.idCategoria equals categoria.idCategoria
                           join proveedor in listaProveedor
                           on producto.idProveedor equals proveedor.idProveedor
                           select new { producto.nombre, categoria.nombreCategoria, nombreProveedor = proveedor.nombre };


            foreach(var item in consulta)
            {
                Console.WriteLine("El producto es " + item.nombre
                    + " cuya categoria es " + item.nombreCategoria
                    + " y el proveedor es " + item.nombreProveedor);
            }

            Console.Read();
        }
    }
}
