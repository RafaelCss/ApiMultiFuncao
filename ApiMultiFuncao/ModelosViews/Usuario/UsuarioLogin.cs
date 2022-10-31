using System.ComponentModel.DataAnnotations;

namespace ApiMultiFuncao.ModelosViews.Usuario
{
    public class UsuarioLogin
    {
        [Required]
        public string Email { get; set; }
		[Required]
		public string Senha { get; set; }
    }
}
