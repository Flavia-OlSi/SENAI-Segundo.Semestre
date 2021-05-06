using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class classeHabilidadeController : ControllerBase
    {
        /// <summary>
        /// Objeto _classeHabilidadeRepository que irá receber todos os metodos definidos na interface IClasseHabilidadeRepository
        /// </summary>
        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }

        public classeHabilidadeController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }

        /// <summary>
        /// Lista todos as classes habilidade
        /// </summary>
        /// <returns>Uma lista de classes habilidades e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_classeHabilidadeRepository.Read());
        }

        /// <summary>
        /// Busca uma classe habilidade através de seu id
        /// </summary>
        /// <param name="id">id da classe habilidade que será buscada</param>
        /// <returns>Uma classe habilidade encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_classeHabilidadeRepository.ReadId(id));
        }
    }
}
