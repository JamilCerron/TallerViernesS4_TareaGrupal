using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPrograS4
{
    public abstract class Producto
    {
        private string nombre;
        private string color;
        private float precio;

        public Producto(string nombre, string color, float precio)
        {
            this.nombre = nombre;
            this.color = color;
            this.precio = precio;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public string ObtenerColor()
        {
            return color;
        }

        public float ObtenerPrecio()
        {
            return precio;
        }


        public virtual string ObtenerCaracteristicas()
        {
            return $"Nombre: {nombre}, Color: {color}, Precio: {precio}";
        }

    }
}
