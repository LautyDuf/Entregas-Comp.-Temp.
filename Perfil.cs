using System;

namespace CT_entrega_1
{
    public abstract class Perfil : Comparable
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

        public virtual bool sosIgual(Comparable c)
        {
            return this.id == ((Perfil)c).getId();
        }

        public virtual bool sosMenor(Comparable c)
        {
            return this.id < ((Perfil)c).getId();
        }

        public virtual bool sosMayor(Comparable c)
        {
            return this.id > ((Perfil)c).getId();
        }
    }
}