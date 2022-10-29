using Flunt.Notifications;
using Flunt.Validations;
using Modelo.Dominio.Notificacao;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
			ValidarEmail(email);
			ValidarSenha(senha);
			ValidarTelefone(telefone);
		}


		public string Id { get; private set; }
		public string Nome { get; private set; }
		public string Email { get; private set; }
		public string Telefone { get; private set; }
		public string Senha { get;	private set; }

		public Usuario ValidarNome(string nome)
		{
			
			Nome = nome;
				AddNotifications(new Contract<Usuario>()
					.Requires()
					.IsNotNullOrEmpty
					(Nome,"Nome","Campo Obrigatório"));
			
			return this;
		}
		public Usuario ValidarEmail(string email)
		{

			Email = email;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsEmailOrEmpty(Email,"Email","Campo Obrigatório")
				)
				;

			return this;
		}
		public Usuario ValidarTelefone(string telefone)
		{

			Telefone = telefone;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsNotNullOrEmpty
				(Telefone,"Telefone","Campo Obrigatório"));

			return this;
		}
		public Usuario ValidarSenha(string senha)
		{

			Senha = senha;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsNotNullOrEmpty
				(Senha,"Senha","Campo Obrigatório"));

			return this;
		}


	}
}
