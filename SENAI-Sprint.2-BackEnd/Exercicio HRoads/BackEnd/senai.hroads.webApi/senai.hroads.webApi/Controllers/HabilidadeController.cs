using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    // Define que tipo de resposta da API será no formato JSON
    [Produces("application/json")]
    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    [Route("api/[controller]")]
    // Define que é um controlador de API
    [ApiController]
    public class HabilidadeController : ControllerBase
    {
        /// <summary>
        /// Objeto _habilidadeRepository que irá receber todos os metodos definidos na interface IHabilidadeRepository
        /// </summary>
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        /// <summary>
        /// Lista todas as habilidades
        /// </summary>
        /// <returns>Uma lista de habilidades e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_habilidadeRepository.Read());
        }

        /// <summary>
        /// Busca uma habilidade através de seu id
        /// </summary>
        /// <param name="id">id da hablidade que será buscada</param>
        /// <returns>Uma habilidade encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_habilidadeRepository.ReadId(id));
        }

        /// <summary>
        /// Cadastra uma nova habilidade 
        /// </summary>
        /// <param name="novaHabilidade">Objeto novaHabilidade que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Habilidade novaHabilidade)
        {
            // Faz a chamada para método 
            _habilidadeRepository.Create(novaHabilidade);

            // Retorna um status code
            return StatusCode(201);
        }
    }
}
