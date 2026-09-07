using System;

namespace CT_entrega_2
{
    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(Mostrable c) : base(c) { }

        public override string mostrarInfo()
        {
            string infoBase = componente.mostrarInfo();
            string nombre = getSuscriptor().getNombre();
            int meses = getSuscriptor().getMesesDeSuscripcion();
            
            return infoBase.Replace(nombre, nombre + " (Suscriptor hace " + meses + " meses)");
        }
    }
}
