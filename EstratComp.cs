using System;

namespace CT_entrega_2
{
    public interface EstratComp
    {
        bool sosIgual(Suscriptor s1, Suscriptor s2);
        bool sosMenor(Suscriptor s1, Suscriptor s2);
        bool sosMayor(Suscriptor s1, Suscriptor s2);
    }
}