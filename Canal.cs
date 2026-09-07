using System;
using System.Collections.Generic;

namespace CT_entrega_2
{
    public class Canal : IComparable
    {
        private string nombre;
        private List<IObservador> observadores;

        public Canal(string n)
        {
            this.nombre = n;
            this.observadores = new List<IObservador>();
        }

        public void agregarObservador(IObservador obs)
        {
            observadores.Add(obs);
        }

        public List<IObservador> getObservadores()
        {
            return observadores;
        }

        public void publicarContenido()
        {
            Console.WriteLine(nombre + " publico contenido nuevo");
            foreach (var obs in observadores)
            {
                obs.verContenido();
            }
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine(nombre + " esta en vivo");
            foreach (var obs in observadores)
            {
                obs.reaccionarANotificacion();
            }
        }

        public bool sosIgual(IComparable c) { return false; }
        public bool sosMenor(IComparable c) { return false; }
        public bool sosMayor(IComparable c) { return false; }
    }
}
