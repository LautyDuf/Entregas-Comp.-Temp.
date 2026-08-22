using System;

namespace CT_entrega_1
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
                Console.WriteLine(e.Message);
            }
        }

        public static void informar(Coleccionable c)
        {
            try
            {
                Console.WriteLine(c.cuantos());
                Console.WriteLine(c.minimo());
                Console.WriteLine(c.maximo());

                int valor = int.Parse(Console.ReadLine());
                Comparable comp = new Visualizacion(valor);

                if (c.contiene(comp))
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leido no está en la colección");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Catalogo catalogo = new Catalogo(pila, cola);

            llenarSuscriptores(pila);
            llenarSuscriptores(cola);

            informar(catalogo);

            Console.ReadKey();
        }
    }
}