using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPrograS4
{
    public class ProductoTela : Producto
    {
        private string material;
        private string tamanio;
        public ProductoTela(string nombre, string color, float precio, string material, string tamanio)
        : base(nombre, color, precio)
        {
            this.material = material;
            this.tamanio = tamanio;
        }
        // Sobrescribir el método de características para incluir los detalles de la tela
        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {ObtenerNombre()}, Material: {material}, Tamaño: {tamanio}, Color: {ObtenerColor()}, Precio: {ObtenerPrecio()}";
        }
    }
}
