using System;

namespace CT_entrega_2
{
    public abstract class Perfil : IComparable
    {
        protected string nombre;
        protected int id;

        public Perfil(string n, int i)
        {
            this.nombre = n;
            this.id = i;
        }

        public string getNombre() { return nombre; }
        public int getId() { return id; }

        public virtual bool sosIgual(IComparable c)
        {
            return this.id == ((Perfil)c).getId();
        }

        public virtual bool sosMenor(IComparable c)
        {
            return this.id < ((Perfil)c).getId();
        }

        public virtual bool sosMayor(IComparable c)
        {
            return this.id > ((Perfil)c).getId();
        }
    }
}