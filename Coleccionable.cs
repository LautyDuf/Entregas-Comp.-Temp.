using System;

namespace CT_entrega_2
{
    public interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable c);
        bool contiene(IComparable c);
    }
}
