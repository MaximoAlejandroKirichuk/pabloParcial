using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Modelos
{
    public class Alumno
    {
		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private int _nroLegajo;

		public int NroLegajo
		{
			get { return _nroLegajo; }
			set { _nroLegajo = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private bool _becado;

		public bool Becado
		{
			get { return _becado; }
			set { _becado = value; }
		}


		public Alumno(int legajo, string apellido, string nombre, int DNI)
        {
            this.NroLegajo = legajo;
			this.Apellido = apellido;
			this.Nombre = nombre;
			this.DNI = DNI;
			this.Becado = false;
        }

        

    }
}
