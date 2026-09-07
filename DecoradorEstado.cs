using System;

namespace CT_entrega_2
{
    public class DecoradorEstado : DecoradorSuscriptor
    {
        public DecoradorEstado(Mostrable c) : base(c) { }

        public override string mostrarInfo()
        {
            string estado = getSuscriptor().getHorasVistas() > 0 ? "Cuenta Activa" : "Cuenta Inactiva";
            string infoBase = componente.mostrarInfo();
            string nombre = getSuscriptor().getNombre();
            
            return infoBase.Replace(nombre, nombre + " (" + estado + ")");
        }
    }
}