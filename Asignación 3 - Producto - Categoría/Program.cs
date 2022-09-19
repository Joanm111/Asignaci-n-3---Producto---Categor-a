using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Producto___Categoría
{
    internal class Program
    {
        static void Main(string[] args)
        {

            categoria perfumes = new categoria();

            perfumes.Id = 1;
            perfumes.Name = "Perfumes";
            perfumes.cantidad = 0;

            perfumes.ProductosList.Add(new producto()
            {
                Id = 1,
                Name = "NITRO",
                precio = 3000,
                cantidad = 2

            });

            perfumes.ProductosList.Add(new producto()
            {
                Id = 2,
                Name = "POLO",
                precio = 2400,
                cantidad = 4

            });



            perfumes.ProductosList.Add(new producto()
            {
                Id = 3,
                Name = "NAUTICA VOYAGE",
                precio = 2200,
                cantidad = 7

            });

            Console.WriteLine("Categoria: " + perfumes.Name);
            double promedio = 0;
            double preciototal = 0;
            double cantidadtotal = 0;
            int cantidadMaxima = 0;
            int cantidadMinima = int.MaxValue;
     
            
            
          

            foreach (var a in perfumes.ProductosList)
            {
                preciototal = preciototal + a.precio;
                cantidadtotal = cantidadtotal + a.cantidad;
             ;

                if (cantidadMaxima <= a.cantidad)
                {
                    cantidadMaxima = a.cantidad;
                }

                if (cantidadMinima >= a.cantidad)
                {
                    cantidadMinima = a.cantidad;

                }

              
            }

            promedio = (preciototal) / cantidadtotal;
            Console.WriteLine($"PROMEDIO:{promedio}\nCANTIDAD MAXIMA:{cantidadMaxima}\nCANTIDAD MINIMA:{cantidadMinima}");

            Console.WriteLine("\n");

            categoria Comida = new categoria();

                Comida.Id = 1;
                Comida.Name = "Comida";
                Comida.cantidad = 0;

                Comida.ProductosList.Add(new producto()
                {
                    Id = 1,
                    Name = "pan integral",
                    precio = 200,
                    cantidad = 15

                });

                Comida.ProductosList.Add(new producto()
                {
                    Id = 2,
                    Name = "Manzana",
                    precio = 20,
                    cantidad = 23

                });


                Comida.ProductosList.Add(new producto()
                {
                    Id = 3,
                    Name = "pera",
                    precio = 25,
                    cantidad = 21

                });


                Comida.ProductosList.Add(new producto()
                {
                    Id = 4,
                    Name = "jugo",
                    precio = 56,
                    cantidad = 32


                });

            Console.WriteLine("Categoria: " + Comida.Name);
            cantidadMinima = int.MaxValue;

            foreach (var a in Comida.ProductosList)
            {
                preciototal = preciototal + a.precio;
                cantidadtotal = cantidadtotal + a.cantidad;

                if (cantidadMaxima <= a.cantidad)
                {
                    cantidadMaxima = a.cantidad;
                }

                if (cantidadMinima >= a.cantidad)
                {
                    cantidadMinima = a.cantidad;

                }







            }

            promedio = (preciototal) / cantidadtotal;
            Console.WriteLine($"PROMEDIO:{promedio}\nCANTIDAD MAXIMA:{cantidadMaxima}\nCANTIDAD MINIMA:{cantidadMinima}");


            Console.WriteLine("\n");




            categoria limpieza = new categoria();

                limpieza.Id = 1;
                limpieza.Name = "Perfumes";
                limpieza.cantidad = 0;

                limpieza.ProductosList.Add(new producto()
                {
                    Id = 1,
                    Name = "Cloro",
                    precio = 200,
                    cantidad = 20

                });

                limpieza.ProductosList.Add(new producto()
                {
                    Id = 1,
                    Name = "fabuloso",
                    precio = 150,
                    cantidad = 30

                });

                limpieza.ProductosList.Add(new producto()
                {
                    Id = 1,
                    Name = "escoba",
                    precio = 240,
                    cantidad = 20

                });


                limpieza.ProductosList.Add(new producto()
                {
                    Id = 1,
                    Name = "recogedor",
                    precio = 223,
                    cantidad = 4

                });

            Console.WriteLine("Categoria: " + limpieza.Name);
            cantidadMinima = int.MaxValue;

            foreach (var a in limpieza.ProductosList)
            {
                preciototal = preciototal + a.precio;
                cantidadtotal = cantidadtotal + a.cantidad;

                if (cantidadMaxima <= a.cantidad)
                {
                    cantidadMaxima = a.cantidad;
                }

                if (cantidadMinima >= a.cantidad)
                {
                    cantidadMinima = a.cantidad;

                }


            }

            promedio = (preciototal) / cantidadtotal;
            Console.WriteLine($"PROMEDIO:{promedio}\nCANTIDAD MAXIMA:{cantidadMaxima}\nCANTIDAD MINIMA:{cantidadMinima}");



            Console.Read();










            
        }
    }
}

