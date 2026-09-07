using System;

namespace CT_entrega_2
{
    public interface IComparable
    {
        bool sosIgual(IComparable c);
        bool sosMenor(IComparable c);
        bool sosMayor(IComparable c);
    }
}
