using System;

namespace CT_entrega_2
{
    public class FabricaDeSuscriptores : FabricaDeIComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Suscriptor(
                GeneradorDeDatosAleatorios.stringAleatorio(6),
                GeneradorDeDatosAleatorios.numeroAleatorio(1000),
                GeneradorDeDatosAleatorios.numeroAleatorio(60),
                GeneradorDeDatosAleatorios.numeroAleatorio(500),
                new EstratXNomb()
            );
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese nombre:");
            string n = LectorDeDatos.stringPorTeclado();
            Console.WriteLine("Ingrese ID:");
            int i = LectorDeDatos.numeroPorTeclado();
            Console.WriteLine("Ingrese meses de suscripcion:");
            int m = LectorDeDatos.numeroPorTeclado();
            Console.WriteLine("Ingrese horas vistas:");
            int h = LectorDeDatos.numeroPorTeclado();

            return new Suscriptor(n, i, m, h, new EstratXNomb());
        }
    }
}
