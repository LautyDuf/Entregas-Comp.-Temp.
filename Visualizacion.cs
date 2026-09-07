using System;

namespace CT_entrega_2
{
    public class Visualizacion : IComparable
    {
        private int cantidad;

        public Visualizacion(int c)
        {
            this.cantidad = c;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public bool sosIgual(IComparable c)
        {
            return this.cantidad == ((Visualizacion)c).getCantidad();
        }

        public bool sosMenor(IComparable c)
        {
            return this.cantidad < ((Visualizacion)c).getCantidad();
        }

        public bool sosMayor(IComparable c)
        {
            return this.cantidad > ((Visualizacion)c).getCantidad();
        }

        public override string ToString()
        {
            return this.cantidad.ToString();
        }
    }
}