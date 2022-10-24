using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dominio.Entidade
{
	public class Usuario 
	{	
		public string Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string Senha { get; set; }
	}
}
