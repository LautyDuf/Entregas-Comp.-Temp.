using System;
using System.Collections.Generic;

namespace CT_entrega_1
{
    public class Pila : Coleccionable
    {
        private List<Comparable> elementos = new List<Comparable>();

        public int cuantos() { return elementos.Count; }

        public void agregar(Comparable c) { elementos.Add(c); }

        public Comparable minimo()
        {
            if (elementos.Count == 0) return null;
            Comparable min = elementos[0];
            foreach (var e in elementos)
            {
                if (e.sosMenor(min)) min = e;
            }
            return min;
        }

        public Comparable maximo()
        {
            if (elementos.Count == 0) return null;
            Comparable max = elementos[0];
            foreach (var e in elementos)
            {
                if (e.sosMayor(max)) max = e;
            }
            return max;
        }

        public bool contiene(Comparable c)
        {
            foreach (var e in elementos)
            {
                if (e.sosIgual(c)) return true;
            }
            return false;
        }
    }
}