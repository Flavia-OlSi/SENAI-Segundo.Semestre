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
    public class TiposDeHabilidadeController : ControllerBase
    {
        /// <summary>
        /// Objeto _tiposDeHabilidadeRepository que irá receber todos os metodos definidos na interface ITiposDeHabilidadesRepository
        /// </summary>
        private ITiposDeHabilidadeRepository _tiposDeHabilidadeRepository { get; set; }    

        public TiposDeHabilidadeController()
        {
            _tiposDeHabilidadeRepository = new TiposDeHabilidadeRepository();
        }

        /// <summary>
        /// Lista todos os tipos de habilidades
        /// </summary>
        /// <returns>Uma lista de tipos de habilidades e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_tiposDeHabilidadeRepository.Read());
        }

        /// <summary>
        /// Busca um tipo de habilidade através de seu id
        /// </summary>
        /// <param name="id">id do tipo de habilidade que será buscada</param>
        /// <returns>Um tipo de habilidade encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_tiposDeHabilidadeRepository.ReadId(id));
        }

        /// <summary>
        /// Cadastra um novo tipo de habilidade
        /// </summary>
        /// <param name="novoTipoDeHabilide">Objeto novoTipoDeHabilidade que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(TiposDeHabilidade novoTipoDeHabilidade)
        {
            // Faz a chamada para método 
            _tiposDeHabilidadeRepository.Create(novoTipoDeHabilidade);

            // Retorna um status code
            return StatusCode(201);
        }
    }
}
