using System;
using System.Collections.Generic;

namespace CT_entrega_2
{
    public class Pila : IColeccionable, Iterable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public int cuantos() { return elementos.Count; }

        public void agregar(IComparable c) { elementos.Add(c); }

        public IComparable minimo()
        {
            if (elementos.Count == 0) return null;
            IComparable min = elementos[0];
            foreach (var e in elementos)
            {
                if (e.sosMenor(min)) min = e;
            }
            return min;
        }

        public IComparable maximo()
        {
            if (elementos.Count == 0) return null;
            IComparable max = elementos[0];
            foreach (var e in elementos)
            {
                if (e.sosMayor(max)) max = e;
            }
            return max;
        }

        public bool contiene(IComparable c)
        {
            foreach (var e in elementos)
            {
                if (e.sosIgual(c)) return true;
            }
            return false;
        }

        public Iterador crearIterador()
        {
            return new IteradorLista(elementos);
        }
    }
}