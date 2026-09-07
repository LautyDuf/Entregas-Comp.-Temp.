using System;

namespace CT_entrega_2
{
    public abstract class DecoradorSuscriptor : Mostrable
    {
        protected Mostrable componente;

        public DecoradorSuscriptor(Mostrable componente)
        {
            this.componente = componente;
        }

        public abstract string mostrarInfo();

        public Suscriptor getSuscriptor()
        {
            return componente.getSuscriptor();
        }
    }
}
