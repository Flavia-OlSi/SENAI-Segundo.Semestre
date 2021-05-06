using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using SENAI.SPMedicalGroup.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Controllers
{
    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá definir todos os métodos definidos  na interface
        /// </summary>
        private IConsultasRepository _consultasRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public ConsultasController()
        {
            _consultasRepository = new ConsultasRepository();
        }

        /// <summary>
        /// Lista todos os consultas
        /// </summary>
        /// <returns>Retorna uma lista de consultas e um status code</returns>
        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_consultasRepository.Listar());
            }
            catch (Exception ex)
            {
                // Retorna a exception e um status code 400 - Bad Request
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Lista todas as consultas por paciente
        /// </summary>
        /// <returns>Retorna uma lista de consultas e um status code</returns>
        [Authorize(Roles = "1, 3")]
        [HttpGet("paciente")]
        public IActionResult GetByPatient()
        {
            try
            {
                // Cria uma variável idUsuario que recebe o valor do ID do usuário que está logado
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                // Retora a resposta da requisição 200 - OK fazendo a chamada para o método e trazendo a lista
                return Ok(_consultasRepository.ListarPorPaciente(idUsuario));
            }
            catch (Exception error)
            {
                // Retorna a exception e um status code 400 - Bad Request
                return BadRequest(new
                {
                    mensagem = "Não é possível mostrar as consultas se o usuário (paciente) não estiver logado!",
                    error
                });
            }
        }

        /// <summary>
        /// Lista todas as consultas por médico
        /// </summary>
        /// <returns>Retorna uma lista de consultas e um status code</returns>
        [Authorize(Roles = "1, 2")]
        [HttpGet("medico")]
        public IActionResult GetByDoctor()
        {
            try
            {
                // Cria uma variável idUsuario que recebe o valor do ID do usuário que está logado
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                // Retora a resposta da requisição 200 - OK fazendo a chamada para o método e trazendo a lista
                return Ok(_consultasRepository.ListarPorMedico(idUsuario));
            }
            catch (Exception error)
            {
                // Retorna a exception e um status code 400 - Bad Request
                return BadRequest(new
                {
                    mensagem = "Não é possível mostrar as consultas se o usuário (paciente) não estiver logado!",
                    error
                });
            }
        }

        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="novaConsulta">Objeto novaConsulta que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Consultas novaConsulta)
        {
            try
            {
                // Faz chamada para o método
                _consultasRepository.Cadastrar(novaConsulta);

                // Retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                // Retorna a exception e um status code 400 - Bad Request
                return BadRequest(ex);
            }
        }
    }
}
