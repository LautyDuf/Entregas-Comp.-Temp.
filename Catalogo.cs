using System;

namespace CT_entrega_1
{
    public class Catalogo : Coleccionable
    {
        private Coleccionable pila;
        private Coleccionable cola;

        public Catalogo(Coleccionable p, Coleccionable c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable minimo()
        {
            Comparable minPila = pila.minimo();
            Comparable minCola = cola.minimo();
            if (minPila == null) return minCola;
            if (minCola == null) return minPila;
            return minPila.sosMenor(minCola) ? minPila : minCola;
        }

        public Comparable maximo()
        {
            Comparable maxPila = pila.maximo();
            Comparable maxCola = cola.maximo();
            if (maxPila == null) return maxCola;
            if (maxCola == null) return maxPila;
            return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
        }

        public void agregar(Comparable c)
        {
        }

        public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}