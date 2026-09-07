using System;
using System.Collections.Generic;

namespace CT_entrega_2
{
    public class IteradorLista : Iterador
    {
        private List<IComparable> elementos;
        private int indiceActual;

        public IteradorLista(List<IComparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }

        public void primero()
        {
            indiceActual = 0;
        }

        public void siguiente()
        {
            indiceActual++;
        }

        public bool fin()
        {
            return indiceActual >= elementos.Count;
        }

        public object actual()
        {
            return elementos[indiceActual];
        }
    }
}
