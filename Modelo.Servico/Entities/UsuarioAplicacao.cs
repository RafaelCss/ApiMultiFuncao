using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Servico.Entities
{
	public class UsuarioAplicacao :  IdentityUser
	{
		public string Email { get; set; }
		public string Senha { get; set; }
	}
}
