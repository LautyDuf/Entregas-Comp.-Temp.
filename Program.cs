/*
 * Created by SharpDevelop.
 * User: Nitro
 * Date: 17/8/2026
 * Time: 18:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
 
namespace Practica01
{
    class Program
    {
        public static void llenar(Coleccionable c)
        {
            try
            {
                Random rnd = new Random();
                for (int i = 0; i < 20; i++)
                {
                    c.agregar(new Visualizacion(rnd.Next(1, 1000)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al llenar la colección: " + e.Message);
            }
        }

        public static void informar(Coleccionable c)
        {
            try
            {
                Console.WriteLine("Cantidad: " + c.cuantos());
                Console.WriteLine("Mínimo: " + c.minimo());
                Console.WriteLine("Máximo: " + c.maximo());

                Console.Write("Ingrese un número para buscar (Visualizacion): ");
                int valor = int.Parse(Console.ReadLine());
                Comparable comp = new Visualizacion(valor);

                if (c.contiene(comp))
                    Console.WriteLine("El elemento leído está en la colección");
                else
                    Console.WriteLine("El elemento leído no está en la colección");
            }
            catch (Exception e)
            {
                // Este catch es para cuando 'informar' mande una 'Visualizacion'a una coleccion de 'Suscriptores', falla el casteo y se atrapa aca.
                Console.WriteLine("\n[EXCEPCIÓN ATRAPADA]: " + e.Message);
            }
            Console.WriteLine("--------------------------------------------------");
        }

        public static void llenarSuscriptores(Coleccionable c)
        {
            try
            {
                Random rnd = new Random();
                string[] nombres = { "Juan", "Maria", "Pedro", "Ana", "Luis" };

                for (int i = 0; i < 20; i++)
                {
                    string nombre = nombres[rnd.Next(nombres.Length)] + i;
                    int id = rnd.Next(1, 1000);
                    int meses = rnd.Next(1, 60);
                    int horas = rnd.Next(1, 500);

                    c.agregar(new Suscriptor(nombre, id, meses, horas));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al llenar suscriptores: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== TP1: Patrones de Diseño (Ej 13 y 14) ===\n");

            Pila pila = new Pila();
            Cola cola = new Cola();
            Catalogo catalogo = new Catalogo(pila, cola);

            Console.WriteLine("Llenando colecciones con Suscriptores al azar...");
            llenarSuscriptores(pila);
            llenarSuscriptores(cola);

            Console.WriteLine("\nInformando datos del Catálogo (que une Pila y Cola):");
            informar(catalogo);

            Console.ReadKey();
        }
    }
}