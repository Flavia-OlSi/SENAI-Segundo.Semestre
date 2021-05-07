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
    public class MedicosController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá definir todos os métodos definidos  na interface
        /// </summary>
        private IMedicosRepository _medicosRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public MedicosController()
        {
            _medicosRepository = new MedicosRepository();
        }
        /// <summary>
        /// Cadastra um novo médico
        /// </summary>
        /// <param name="novoMedico">Objeto novoMedico que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Medicos novoMedico)
        {
            try
            {
                // Faz chamada para o método
                _medicosRepository.Cadastrar(novoMedico);

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
