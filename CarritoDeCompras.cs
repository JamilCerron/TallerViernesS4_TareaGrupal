using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPrograS4
{
    public class CarritoDeCompras
    {
        private List<Producto> productos;

        public CarritoDeCompras()
        {
            productos = new List<Producto>();
        }

        
        public void AgregarProductoPorIndice(List<Producto> listaDeProductos, int indice)
        {
            if (indice >= 0 && indice < listaDeProductos.Count)
            {
                Producto productoSeleccionado = listaDeProductos[indice];
                productos.Add(productoSeleccionado);
                Console.WriteLine($"{productoSeleccionado.ObtenerNombre()} ha sido añadido al carrito.\n");
            }
            else
            {
                Console.WriteLine("Índice inválido.\n");
            }
        }

        
        public float ObtenerPrecioTotal()
        {
            float total = 0;
            foreach (var producto in productos)
            {
                total += producto.ObtenerPrecio();
            }
            return total;
        }

        
        public void MostrarCarrito()
        {
            Console.WriteLine("Contenido del carrito:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
            Console.WriteLine($"Total: {ObtenerPrecioTotal()}\n");
        }

       
        public void VaciarCarrito()
        {
            productos.Clear();
            Console.WriteLine("El carrito ha sido vaciado.\n");
        }
    }
}
}
