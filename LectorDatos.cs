using System;

namespace CT_entrega_2
{
    public class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine());
        }

        public static string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}