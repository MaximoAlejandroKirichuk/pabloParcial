using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Modelos
{
    public class Beca
    {
		private int _monto;

		public int Monto
		{
			get { return _monto; }
			set { _monto = value; }
		}

		private int _codigoBeca;

		public int CodigoBeca
		{
			get { return _codigoBeca; }
			set { _codigoBeca = value; }
		}

        public Beca()
        {
            
        }

    }
}
