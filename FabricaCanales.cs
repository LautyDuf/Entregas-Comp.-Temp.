using System;

namespace CT_entrega_2
{
    public class FabricaDeCanales : FabricaDeIComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Canal(GeneradorDeDatosAleatorios.stringAleatorio(8));
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese nombre del canal:");
            return new Canal(LectorDeDatos.stringPorTeclado());
        }
    }
}