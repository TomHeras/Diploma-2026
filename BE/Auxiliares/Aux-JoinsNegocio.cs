using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Auxiliares
{
    public class Aux_JoinsNegocio
    {

		private int idpedido;

		public int ID_pedido
		{
			get { return idpedido; }
			set { idpedido = value; }
		}

		private string cliente;

		public string Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		private double total;

		public double Total
		{
			get { return total; }
			set { total = value; }
		}

		private string estado;

		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private DateTime gen;

		public DateTime Generado
		{
			get { return gen; }
			set { gen = value; }
		}

		private DateTime act;

		public DateTime Actualizado
		{
			get { return act; }
			set { act = value; }
		}

	}
}
