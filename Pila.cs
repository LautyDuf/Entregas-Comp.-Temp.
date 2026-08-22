/*
 * Created by SharpDevelop.
 * User: Nitro
 * Date: 17/8/2026
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
 
namespace Practica01
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

    public class Cola : Coleccionable
    {
        private List<Comparable> elementos = new List<Comparable>();

        public int cuantos() { return elementos.Count; }
        public void agregar(Comparable c) { elementos.Add(c); }

        public Comparable minimo()
        {
            if (elementos.Count == 0) return null;
            Comparable min = elementos[0];
            foreach (var e in elementos) if (e.sosMenor(min)) min = e;
            return min;
        }

        public Comparable maximo()
        {
            if (elementos.Count == 0) return null;
            Comparable max = elementos[0];
            foreach (var e in elementos) if (e.sosMayor(max)) max = e;
            return max;
        }

        public bool contiene(Comparable c)
        {
            foreach (var e in elementos) if (e.sosIgual(c)) return true;
            return false;
        }
    }

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
            // Segun el PDF: no hace nada
        }

        public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}