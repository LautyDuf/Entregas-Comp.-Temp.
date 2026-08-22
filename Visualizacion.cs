using System;

namespace CT_entrega_1
{
    public class Visualizacion : Comparable
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

        public bool sosIgual(Comparable c)
        {
            return this.cantidad == ((Visualizacion)c).getCantidad();
        }

        public bool sosMenor(Comparable c)
        {
            return this.cantidad < ((Visualizacion)c).getCantidad();
        }

        public bool sosMayor(Comparable c)
        {
            return this.cantidad > ((Visualizacion)c).getCantidad();
        }

        public override string ToString()
        {
            return this.cantidad.ToString();
        }
    }
}