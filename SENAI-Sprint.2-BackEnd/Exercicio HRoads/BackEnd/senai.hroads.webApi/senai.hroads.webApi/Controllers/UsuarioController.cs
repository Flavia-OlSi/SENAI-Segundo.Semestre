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
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Objeto _usuarioRepository que irá receber todos os metodos definidos na interface ITiposDeUsuarioRepository
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição
            return Ok(_usuarioRepository.Read());
        }

        /// <summary>
        /// Busca um usuario através de seu id
        /// </summary>
        /// <param name="id">id do usuario que será buscada</param>
        /// <returns>Um usuario encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a respota da requisão fazendo a chamada para o método
            return Ok(_usuarioRepository.ReadId(id));
        }

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoTipoDeUsuario">Objeto novoUsuario que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            // Faz a chamada para método 
            _usuarioRepository.Create(novoUsuario);

            // Retorna um status code
            return StatusCode(201);
        }
    }
}
