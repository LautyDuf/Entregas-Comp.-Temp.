using System;

namespace CT_entrega_2
{
    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable c) : base(c) { }

        public override string mostrarInfo()
        {
            string info = componente.mostrarInfo();
            string asteriscos = new string('*', info.Length + 4);
            
            return asteriscos + "\n* " + info + " *\n" + asteriscos;
        }
    }
}