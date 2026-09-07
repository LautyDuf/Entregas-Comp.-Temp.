using System;

namespace CT_entrega_2
{
    public class Suscriptor : Perfil, IObservador, Mostrable
    {
        private int mesesDeSuscripcion;
        private int horasVistas;
        private EstratComp estrategia;

        public Suscriptor(string n, int i, int m, int h, EstratComp e) : base(n, i)
        {
            this.mesesDeSuscripcion = m;
            this.horasVistas = h;
            this.estrategia = e;
        }

        public void setEstrategia(EstratComp e)
        {
            this.estrategia = e;
        }

        public int getMesesDeSuscripcion() { return mesesDeSuscripcion; }
        public int getHorasVistas() { return horasVistas; }

        public override bool sosIgual(IComparable c)
        {
            return estrategia.sosIgual(this, (Suscriptor)c);
        }

        public override bool sosMenor(IComparable c)
        {
            return estrategia.sosMenor(this, (Suscriptor)c);
        }

        public override bool sosMayor(IComparable c)
        {
            return estrategia.sosMayor(this, (Suscriptor)c);
        }

        public void verContenido()
        {
            Console.WriteLine("Viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            int r = GeneradorDeDatosAleatorios.numeroAleatorio(2);
            if (r == 0) Console.WriteLine("Abriendo la notificacion");
            else if (r == 1) Console.WriteLine("Lo veo despues");
            else Console.WriteLine("Silenciando notificaciones");
        }

        public string mostrarInfo()
        {
            return nombre + " - " + horasVistas + " horas vistas";
        }

        public Suscriptor getSuscriptor()
        {
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} (Id:{1}, Meses:{2}, Horas:{3})", nombre, id, mesesDeSuscripcion, horasVistas);
        }
    }
}