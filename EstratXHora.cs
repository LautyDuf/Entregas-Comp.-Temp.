using System;

namespace CT_entrega_2
{
    public class EstratXHora : EstratComp
    {
        public bool sosIgual(Suscriptor s1, Suscriptor s2)
        {
            return s1.getHorasVistas() == s2.getHorasVistas();
        }

        public bool sosMenor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getHorasVistas() < s2.getHorasVistas();
        }

        public bool sosMayor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getHorasVistas() > s2.getHorasVistas();
        }
    }
}
