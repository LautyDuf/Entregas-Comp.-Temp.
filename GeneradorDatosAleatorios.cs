using System;

namespace CT_entrega_2
{
    public class GeneradorDeDatosAleatorios
    {
        private static Random rnd = new Random();

        public static int numeroAleatorio(int max)
        {
            return rnd.Next(0, max + 1);
        }

        public static string stringAleatorio(int cant)
        {
            string letras = "abcdefghijklmnopqrstuvwxyz";
            string res = "";
            for (int i = 0; i < cant; i++)
            {
                res += letras[rnd.Next(letras.Length)];
            }
            return res;
        }
    }
}
