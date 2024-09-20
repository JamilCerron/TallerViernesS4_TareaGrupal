﻿using System;
using System.Collections.Generic;

namespace TareaGrupalPrograS4
{
    internal class MenuCompras
    {

        //private List<Producto> productosDisponiblesEnLaTienda;
        //private CarritoDeCompras carrito;

        bool continuarMenu = true, seguirAñadiendo = true, seguirFinalizando=true;

        //public  MenuCompras()
        //{
        //    carrito = new CarritoDeCompras();
        //    productosDisponibles = new List<Producto>;

        //    new ProductoTela("Bolsa", "Rojo", 25.99f, "Algodón", "Mediano");
        //    new ProductoTela("Tapete", "Azul", 35.50f, "Lana", "Grande");
        //    new ProductoArcilla("Vasija", "Marrón", 50.00f, "Pequeño", 2.5);
        //    new ProductoArcilla("Estatuilla", "Negro", 75.00f, "Mediano", 4.0);

        //}
        public void EjecutarMenuCompras()
        {

            


            while (continuarMenu)
            {
                seguirAñadiendo = true; seguirFinalizando = true;
                Console.WriteLine("Por favor , seleccione una de las siguientes opciones:");
                Console.WriteLine("1.Añadir un nuevo producto al carrito de compras");
                Console.WriteLine("2.Ver el contenido del carrito");
                Console.WriteLine("3.Finalizar la compra");

                string entradaMenuCompras = Console.ReadLine();


                if (int.TryParse(entradaMenuCompras, out int valor1) && valor1 <= 3)
                {
                    switch (valor1)
                    {
                        case 1: AñadirProductoAlCarrito(); break;
                        case 2: VerContenidoDelCarrito(); break;
                        case 3: FinalizarCompra(); break;
                    }
                }

                else MensajeDeOpcionInvalida();

            }

        }


        void AñadirProductoAlCarrito()
        {
            while (seguirAñadiendo)
            {

                Console.WriteLine("A continuacion, se le mostrara la lista de productos del inventario de la tienda");
                //for (int i = 0; i < productosDisponibles.Count; i++)
                //{
                //  Console.WriteLine($"{i + 1}. {productosDisponibles[i].ObtenerNombre()}");
                //}


                    Console.WriteLine("Elija el producto que desea añadir al carrito");

                string entradaNumeroDeLaLista = Console.ReadLine();

                if (int.TryParse(entradaNumeroDeLaLista, out int NumeroDeLaLista))// && NumeroDeLaLista <= productosDisponiblesEnLaTienda.Count)
                {
                    Console.WriteLine("El producto elegido cuenta con las siguientes caracteristicas");
                    // Metodo que retorna las caracteristicas del producto en un Console.Writeline
                    Console.WriteLine("¿Desea añadir este producto a su carrito de compras?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    string entradaDeOpcion = Console.ReadLine();
                    if (int.TryParse(entradaDeOpcion, out int opcion) && opcion <= 2)
                    {
                        switch (opcion)
                        {
                            case 1:
                                //carrito.AgregarProductoPorIndice(productosDisponiblesEnLaTienda, indice - 1); 
                                Console.WriteLine("Producto añadido al carrito de compras");
                                Console.WriteLine("¿Desea continuar agregando productos al carrito compras?");
                                Console.WriteLine("1.Si");
                                Console.WriteLine("2.No");
                                entradaDeOpcion = Console.ReadLine();

                                if (int.TryParse(entradaDeOpcion, out opcion) && opcion <= 2)
                                {

                                    if (opcion == 2) seguirAñadiendo = false;
                                }
                                else MensajeDeOpcionInvalida();
                                break;

                            case 2: seguirAñadiendo = false; break;
                        }
                    }
                    else MensajeDeOpcionInvalida();
                }

                else  MensajeDeOpcionInvalida();
            }

        }

        void VerContenidoDelCarrito()
        {

            Console.WriteLine("A continuacion, la lista de los productos guardados en su carrito de compras");
            //for (int i = 0; i < productosDisponibles.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {productosDisponiblesEnLaTienda[i].ObtenerNombre()}");
            //}

        }

        void FinalizarCompra()
        {
            while (seguirFinalizando)
            {
                Console.WriteLine("Boleta de compra:");
                //Metodo que retorne la lista de los nombres de los productos en el carrito y el precio total
                Console.WriteLine("Gracias por su compra,compra finalizada");
                Console.WriteLine("Seleccione una de las opciones a continuacion ");
                Console.WriteLine("1.Crear nuevo carrito de compras");
                Console.WriteLine("2.Salir del programa");

                string entradaDeOpcion = Console.ReadLine();
                if (int.TryParse(entradaDeOpcion, out int opcion) && opcion <= 2)
                {
                    switch (opcion)
                    {
                        case 1:

                            Console.WriteLine("Carrito de compras creado");
                            seguirFinalizando = false;

                            break;

                        case 2: FinalizarPrograma(); break;
                    }
                }
            }
            
        }


        void MensajeDeOpcionInvalida()
        {
            Console.WriteLine("Opción invalida. Porfavor vuelva a marcar una de las opciones");
        }

        void FinalizarPrograma()
        {
            continuarMenu = false;
            seguirFinalizando= false;   
        }
    }
}
