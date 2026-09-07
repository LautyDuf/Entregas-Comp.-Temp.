using System;
using System.Collections.Generic;

namespace CT_entrega_2
{
    public class Playlist : IColeccionable, Iterable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public int cuantos()
        {
            return elementos.Count;
        }

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

        public bool pertenece(IComparable c)
        {
            foreach (var e in elementos)
            {
                if (e.sosIgual(c)) return true;
            }
            return false;
        }

        public void agregar(IComparable c)
        {
            if (!pertenece(c))
            {
                elementos.Add(c);
            }
        }

        public bool contiene(IComparable c)
        {
            return pertenece(c);
        }

        public Iterador crearIterador()
        {
            return new IteradorLista(elementos);
        }
    }
}