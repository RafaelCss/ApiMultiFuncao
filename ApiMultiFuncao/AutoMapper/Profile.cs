using ApiMultiFuncao.ModelosViews.Usuario;
using AutoMapper;
using Modelo.Dominio.Entidade;

namespace ApiMultiFuncao.AutoMapper
{
	public class AutoMapperClasses :Profile

	{
		public AutoMapperClasses()
		{
			CreateMap<UsuarioLogin,Usuario>();
			CreateMap<UsuarioCadastrar,Usuario>();

		}
	}


}