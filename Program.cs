using System;
using System.Collections.Generic;

namespace CT_entrega_2
{
    class Program
    {
        public static void imprimirElementos(Iterable IColeccionable)
        {
            Iterador it = IColeccionable.crearIterador();
            while (!it.fin())
            {
                Console.WriteLine(it.actual());
                it.siguiente();
            }
        }

        public static void cambiarEstrategia(Iterable IColeccionable, EstratComp estrategia)
        {
            Iterador it = IColeccionable.crearIterador();
            while (!it.fin())
            {
                Suscriptor elem = (Suscriptor)it.actual();
                elem.setEstrategia(estrategia);
                it.siguiente();
            }
        }

        public static void llenarFactory(IColeccionable IColeccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable IComparable = FabricaDeIComparables.crearAleatorio(opcion);
                IColeccionable.agregar(IComparable);
            }
        }

        public static void informarFactory(IColeccionable IColeccionable, int opcion)
        {
            Console.WriteLine(IColeccionable.cuantos());
            Console.WriteLine(IColeccionable.minimo());
            Console.WriteLine(IColeccionable.maximo());

            IComparable IComparable = FabricaDeIComparables.crearPorTeclado(opcion);

            if (IColeccionable.contiene(IComparable))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }
        }

        public static void temporadaDeContenido(Canal canal)
        {
            for (int i = 0; i < 5; i++)
            {
                canal.publicarContenido();
                canal.iniciarEnVivo();
            }
        }

        static void Main(string[] args)
        {
            Canal canal = new Canal("CTYPDS UNAJ");

            for (int i = 0; i < 10; i++)
            {
                Suscriptor suscriptor = (Suscriptor)FabricaDeIComparables.crearAleatorio(FabricaDeIComparables.SUSCRIPTOR);
                canal.agregarObservador(suscriptor);
            }

            temporadaDeContenido(canal);

            Console.WriteLine("\n--- Mostrando suscriptores con decoradores ---");
            foreach (IObservador obs in canal.getObservadores())
            {
                Mostrable mostrable = (Suscriptor)obs;
                mostrable = new DecoradorAntiguedad(mostrable);
                mostrable = new DecoradorNivel(mostrable);
                mostrable = new DecoradorEstado(mostrable);
                mostrable = new DecoradorRecuadro(mostrable);
                
                Console.WriteLine(mostrable.mostrarInfo());
            }

            Console.ReadKey();
        }
    }
}