using ApiMultiFuncao.ModelosViews.Usuario;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dominio.Entidade;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMultiFuncao.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		private readonly IMapper _mapper;

		public UsuarioController(IMapper mapper)
		{
			_mapper = mapper;
		}

		[HttpPost]
		[Route("CadastrarUsuario")]
		public ActionResult Cadastar([FromBody] UsuarioCadastrar usuario)
		{
			var user = _mapper.Map<Usuario>(usuario);

			return Ok(user);

		}

		[HttpPost]
		[Route("Login")]
		public ActionResult Logar([FromBody] UsuarioLogin usuario)
		{
			var user = _mapper.Map<Usuario>(usuario);

			return Ok(user);

		}

		// PUT api/<ValuesController>/5
		[HttpPut("{id}")]
		public void Put(int id,[FromBody] string value)
		{
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
