using System;

namespace CT_entrega_2
{
    public class Catalogo : IColeccionable
    {
        private IColeccionable pila;
        private IColeccionable cola;

        public Catalogo(IColeccionable p, IColeccionable c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable minimo()
        {
            IComparable minPila = pila.minimo();
            IComparable minCola = cola.minimo();
            if (minPila == null) return minCola;
            if (minCola == null) return minPila;
            return minPila.sosMenor(minCola) ? minPila : minCola;
        }

        public IComparable maximo()
        {
            IComparable maxPila = pila.maximo();
            IComparable maxCola = cola.maximo();
            if (maxPila == null) return maxCola;
            if (maxCola == null) return maxPila;
            return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
        }

        public void agregar(IComparable c)
        {
        }

        public bool contiene(IComparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}