using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
		private PuestoAtencion caja;
		private string nombre;
		private Queue<Cliente> clientes;

		public Cliente Clientes
		{
			get
			{
				return this.clientes.First();
			}
		}
	}
}
