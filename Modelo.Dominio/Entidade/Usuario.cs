using Flunt.Notifications;
using Modelo.Dominio.Notificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dominio.Entidade
{
	public class Usuario : EntidadeNotificacao
	{

		public Usuario(string nome, string email, string telefone, string senha )
		{
			ValidarNome(nome);
		}


		public string Id { get; private set; }
		public string Nome { get; private set; }
		public string Email { get; private set; }
		public string Telefone { get; private set; }
		public string Senha { get;	private set; }

		public string ValidarNome(string nome)
		{
			if(string.IsNullOrWhiteSpace(nome))
				Nome = nome;
			return Nome;
		}
			 
	}
}
