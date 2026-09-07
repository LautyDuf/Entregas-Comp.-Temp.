using System;

namespace CT_entrega_2
{
    public class EstratXMes : EstratComp
    {
        public bool sosIgual(Suscriptor s1, Suscriptor s2)
        {
            return s1.getMesesDeSuscripcion() == s2.getMesesDeSuscripcion();
        }

        public bool sosMenor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getMesesDeSuscripcion() < s2.getMesesDeSuscripcion();
        }

        public bool sosMayor(Suscriptor s1, Suscriptor s2)
        {
            return s1.getMesesDeSuscripcion() > s2.getMesesDeSuscripcion();
        }
    }
}
