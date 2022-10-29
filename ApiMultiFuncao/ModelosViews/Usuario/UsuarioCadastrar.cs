using System.ComponentModel.DataAnnotations;

namespace ApiMultiFuncao.ModelosViews.Usuario
{
	public class UsuarioCadastrar
	{
		
		public string Nome { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Telefone { get; set; }
		[Required]
		public string Senha { get; set; }
	}
}
