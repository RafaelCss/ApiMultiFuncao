using Flunt.Notifications;
using Flunt.Validations;
using Modelo.Dominio.Notificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dominio.Entidade
{
	public class Usuario : Notifiable<Notification>
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

		public Usuario ValidarNome(string nome)
		{
			if(Nome.Equals(nome)) return this;
			Nome = nome;
				AddNotifications(new Contract<Usuario>()
					.Requires()
					.IsNotNull(Nome,"Nome","Campo Obrigatório"));
			
			return this;
		}
			 
	}
}
