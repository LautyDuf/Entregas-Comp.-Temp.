using System;

namespace CT_entrega_1
{
	public class Suscriptor : Perfil
	{
		private int mesesDeSuscripcion;
		private int horasVistas;

		public Suscriptor(string n, int i, int m, int h) : base(n, i)
		{
			this.mesesDeSuscripcion = m;
			this.horasVistas = h;
		}

		public int getMesesDeSuscripcion() { return mesesDeSuscripcion; }
		public int getHorasVistas() { return horasVistas; }

		public override bool sosIgual(Comparable c)
		{
			return this.mesesDeSuscripcion == ((Suscriptor)c).getMesesDeSuscripcion();
		}

		public override bool sosMenor(Comparable c)
		{
			return this.mesesDeSuscripcion < ((Suscriptor)c).getMesesDeSuscripcion();
		}

		public override bool sosMayor(Comparable c)
		{
			return this.mesesDeSuscripcion > ((Suscriptor)c).getMesesDeSuscripcion();
		}

		public override string ToString()
		{
			return string.Format("{0} (Id:{1}, Meses:{2}, Horas:{3})", nombre, id, mesesDeSuscripcion, horasVistas);
		}
	}
}