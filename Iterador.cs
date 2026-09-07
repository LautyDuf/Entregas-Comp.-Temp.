using System;

namespace CT_entrega_2
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        object actual();
    }
}
