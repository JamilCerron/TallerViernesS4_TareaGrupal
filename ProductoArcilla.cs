using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPrograS4
{
    public class ProductoArcilla : Producto
    {
        private string tamaño;
        private double peso;

        public ProductoArcilla(string nombre, string color, float precio, string tamaño, double peso)
            : base(nombre, color, precio)
        {
            this.tamaño = tamaño;
            this.peso = peso;
        }

        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {ObtenerNombre()}, Tamaño: {tamaño}, Peso: {peso}kg, Color: {ObtenerColor()}, Precio: {ObtenerPrecio()}";
        }
    }
}
