/*
 * Created by SharpDevelop.
 * User: Nitro
 * Date: 17/8/2026
 * Time: 19:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
 
namespace Practica01
{
	// Ejercicio 2
	public class Visualizacion : Comparable
	{
		private int cantidad;

		public Visualizacion(int c)
		{
			this.cantidad = c;
		}

		public int getCantidad()
		{
			return cantidad;
		}

		public bool sosIgual(Comparable c)
		{
			return this.cantidad == ((Visualizacion)c).getCantidad();
		}

		public bool sosMenor(Comparable c)
		{
			return this.cantidad < ((Visualizacion)c).getCantidad();
		}

		public bool sosMayor(Comparable c)
		{
			return this.cantidad > ((Visualizacion)c).getCantidad();
		}

		public override string ToString()
		{
			return this.cantidad.ToString();
		}
	}

	// Ejercicio 10
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

	// Ejercicio 11 y 14
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

		// Ejercicio 14: Reimplementando Comparable para comparar por meses de suscripción
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
			return nombre + " (Id:" + id + ", Meses:" + mesesDeSuscripcion + ", Horas:" + horasVistas + ")";
		}
	}
}
