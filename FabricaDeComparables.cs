using System;

namespace CT_entrega_2
{
    public abstract class FabricaDeIComparables
    {
        public const int VISUALIZACION = 1;
        public const int SUSCRIPTOR = 2;
        public const int CANAL = 3;

        public static IComparable crearAleatorio(int opcion)
        {
            FabricaDeIComparables fabrica = null;
            if (opcion == VISUALIZACION) fabrica = new FabricaDeVisualizaciones();
            else if (opcion == SUSCRIPTOR) fabrica = new FabricaDeSuscriptores();
            else if (opcion == CANAL) fabrica = new FabricaDeCanales();
            
            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            FabricaDeIComparables fabrica = null;
            if (opcion == VISUALIZACION) fabrica = new FabricaDeVisualizaciones();
            else if (opcion == SUSCRIPTOR) fabrica = new FabricaDeSuscriptores();
            else if (opcion == CANAL) fabrica = new FabricaDeCanales();
            
            return fabrica.crearPorTeclado();
        }

        public abstract IComparable crearAleatorio();
        public abstract IComparable crearPorTeclado();
    }
}