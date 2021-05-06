using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using SENAI.SPMedicalGroup.WebApi.Repositories;
using System;
using System.Collections.Generic;
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
    public class PacientesController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá definir todos os métodos definidos  na interface
        /// </summary>
        private IPacientesRepository _pacientesRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public PacientesController()
        {
            _pacientesRepository = new PacientesRepository();
        }

        /// <summary>
        /// Lista todos os pacientes
        /// </summary>
        /// <returns>Retorna uma lista de pacientes e um status code</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_pacientesRepository.Listar());
            }
            catch(Exception ex)
            {
                // Retorna a exception e um status code 400 - Bad Request
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo paciente
        /// </summary>
        /// <param name="novoPaciente">Objeto novoPaciente que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Pacientes novoPaciente)
        {
            try
            {
                // Faz chamada para o método
                _pacientesRepository.Cadastrar(novoPaciente);

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
