using CorujasDev.Identity.Servicos.Interfaces;
using CorujasDev.Identity.Servicos.ViewModels.Login;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CorujasDev.Identity.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;

        public AccountController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                string tokenUsuario = _usuarioServico.Autenticar(login);

                if (string.IsNullOrEmpty(tokenUsuario)) 
                    return NotFound(new { mensagem = "Email ou Senha Inválidos." });

                return Ok(new { token = tokenUsuario });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao cadastrar." + ex.Message });
            }
        }
    }
}