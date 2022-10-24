using Flunt.Notifications;
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

		public string ValidarNome(string nome)
		{
			if(nome.Length > 0) Nome = nome;

			AddNotifications(Nome, "Este campo não pode ficar vazio");

			return nome;
		}
			 
	}
}
