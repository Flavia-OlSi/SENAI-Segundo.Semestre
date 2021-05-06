using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
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
    public class TiposDeUsuarioController : ControllerBase
    {
        /// <summary>
        /// Objeto _tiposDeUsuarioRepository que irá receber todos os metodos definidos na interface ITiposDeUsuarioRepository
        /// </summary>
        private ITiposDeUsuarioRepository _tiposDeUsuarioRepository { get; set; }

        /// <summary>
        /// Lista todos os tipos de usuarios
        /// </summary>
        /// <returns>Uma lista de tipos de usuarios e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_tiposDeUsuarioRepository.Read());
        }

        /// <summary>
        /// Busca um tipo de usuario através de seu id
        /// </summary>
        /// <param name="id">id do tipo de usuario que será buscada</param>
        /// <returns>Um tipo de usuario encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_tiposDeUsuarioRepository.ReadId(id));
        }

        /// <summary>
        /// Cadastra um novo tipo de usuario
        /// </summary>
        /// <param name="novoTipoDeUsuario">Objeto novoTipoDeUsuario que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(TiposDeUsuario novoTipoDeUsuario)
        {
            // Faz a chamada para método 
            _tiposDeUsuarioRepository.Create(novoTipoDeUsuario);

            // Retorna um status code
            return StatusCode(201);
        }

    }
}
