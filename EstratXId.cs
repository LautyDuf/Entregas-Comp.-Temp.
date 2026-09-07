using System;

namespace CT_entrega_2
{
    public class EstratXId : EstratComp
    {
        public bool sosIgual(Suscriptor s1, Suscriptor s2)
        {
            return s1.getId() == s2.getId();
        }

        public bool sosMenor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getId() < s2.getId();
        }

        public bool sosMayor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getId() > s2.getId();
        }
    }
}
