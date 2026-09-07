using System;

namespace CT_entrega_2
{
    public class DecoradorNivel : DecoradorSuscriptor
    {
        public DecoradorNivel(Mostrable c) : base(c) { }

        public override string mostrarInfo()
        {
            int horas = getSuscriptor().getHorasVistas();
            string nivel = "Bronce";
            
            if (horas >= 50) nivel = "Oro";
            else if (horas >= 10) nivel = "Plata";

            return "[" + nivel + "] " + componente.mostrarInfo();
        }
    }
}