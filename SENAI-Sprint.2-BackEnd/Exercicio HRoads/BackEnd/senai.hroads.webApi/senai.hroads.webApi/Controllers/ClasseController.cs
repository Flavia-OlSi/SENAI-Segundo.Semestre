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
    [Produces("application/json")]
    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    [Route("api/[controller]")]
    // Define que é um controlador de API
    [ApiController]
    public class ClasseController : ControllerBase
    {
        /// <summary>
        /// Objeto _tiposDeHabilidade que irá receber todos os metodos definidos na interface IClasseRepository
        /// </summary>
        private IClasseRepository _classeRepository { get; set; }

        public ClasseController()
        {
            _classeRepository = new ClasseRepository();
        }

        /// <summary>
        /// Lista todos as classes
        /// </summary>
        /// <returns>Uma lista de classes e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_classeRepository.Read());
        }

        /// <summary>
        /// Busca uma classe através de seu id
        /// </summary>
        /// <param name="id">id da classe que será buscada</param>
        /// <returns>Uma classe encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_classeRepository.ReadId(id));
        }

        /// <summary>
        /// Cadastra uma nova classe
        /// </summary>
        /// <param name="novaClasse">Objeto novaClasse que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Classe novaClasse)
        {
            // Faz a chamada para método 
            _classeRepository.Create(novaClasse);

            // Retorna um status code
            return StatusCode(201);
        }

    }
}
