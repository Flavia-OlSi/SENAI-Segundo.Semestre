using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using SENAI.SPMedicalGroup.WebApi.Repositories;
using SENAI.SPMedicalGroup.WebApi.ViewMoels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Controllers
{
    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá definir todos os métodos definidos  na interface
        /// </summary>
        private IUsuariosRepository _usuariosRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public LoginController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                // Busca um usuário pelo e-mail e senha
                Usuarios usuarioBuscado = _usuariosRepository.Login(login.Email, login.Senha);

                // Caso não encontre um usuário com o e-mail e a senha informados
                if(usuarioBuscado == null)
                {
                    // Retorna NotFound com uma mensagem personalizada
                    return NotFound("E-mail ou senha inválidos");
                }

                // Define os dados que serão fornecidos no token - Payload
                var claims = new[]
                {
                    // Armazena na Claim o e-mail do usuário 
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),

                    // Armazena na Claim o id do usuário autenticado
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.idUsuario.ToString()),

                    // Armazena na Claim o id do tipo de usuário que foi autenticado
                    new Claim(ClaimTypes.Role, usuarioBuscado.idTipo.ToString())
                };

                // Define a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("SPMedicalGroup-chave-autenticacao"));

                // Define as credenciais
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var dadosToken = new JwtSecurityToken(
                   issuer: "SPMedicalGroup.webApi",                   // emissor do token
                    audience: "SPMedicalGroup.webApi",               // destinatário do token
                    claims: claims,                                 // dados definidos acima
                    expires: DateTime.Now.AddMinutes(30),           // tempo de expiração
                    signingCredentials: creds                       // credenciais do token
                );

                // Retorna Ok com o token
                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(dadosToken)
                });  
            }
            catch (Exception ex)
            {
                // Cado o usuário não seja encontrado, ou aconteça algum erro, retorna o código da exception
                return BadRequest(ex);
            }
        }

    }
}
