using Flunt.Notifications;
using Modelo.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Servico.Servicos
{
	public interface IServicos : INotifiable
	{
		public Task<Usuario> CadastrarUsuario(string nome, string telefone, string email, string senha);
		public Task<Usuario> EditarUsuario(Guid id,string nome,string telefone,string email,string senha);
		public Task<Usuario> ExcluirUsuario(Guid id);
	}
}
