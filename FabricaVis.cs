using System;

namespace CT_entrega_2
{
    public class FabricaDeVisualizaciones : FabricaDeIComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Visualizacion(GeneradorDeDatosAleatorios.numeroAleatorio(1000));
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese la cantidad para la visualizacion:");
            return new Visualizacion(LectorDeDatos.numeroPorTeclado());
        }
    }
}
