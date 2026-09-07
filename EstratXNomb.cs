using System;

namespace CT_entrega_2
{
    public class EstratXNomb : EstratComp
    {
        public bool sosIgual(Suscriptor s1, Suscriptor s2)
        {
            return s1.getNombre() == s2.getNombre();
        }

        public bool sosMenor(Suscriptor s1, Suscriptor s2)
        {
            return string.Compare(s1.getNombre(), s2.getNombre()) < 0;
        }

        public bool sosMayor(Suscriptor s1, Suscriptor s2)
        {
            return string.Compare(s1.getNombre(), s2.getNombre()) > 0;
        }
    }
}