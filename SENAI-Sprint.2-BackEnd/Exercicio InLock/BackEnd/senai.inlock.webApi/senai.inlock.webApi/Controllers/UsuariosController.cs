using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controller responsáveis pelos endpoints (URLs) referentes aos tipos
/// </summary>
namespace senai.inlock.webApi.Controllers
{
    // Define que o tipo de resposta da API será em formato JSON
    [Produces("application/json")]
    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    // ex: http://localhost:5000/api/Usuarios
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        /// <summary>
        /// Objeto _usuariosRepository que irá receber todos os métodos definidos na interface IUsuariosRepository
        /// </summary>
        private IUsuariosRepository _usuariosRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _usuariosRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios e um status code</returns>
        /// dominio/api/usuarios
        [HttpGet]
        public IActionResult GetAll()
        {
            // Cria uma lista nomeada listaTipos para receber os dados
            List<UsuariosDomain> listaUsuarios = _usuariosRepository.ReadAll();

            // Retorna o status code 200 (Ok) com a lista de usuarios no formato JSON
            return Ok(listaUsuarios);
        }

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario recebido na requisição</param>
        /// <returns>um status code 201 - Create</returns>
        /// http://localhost:5000/api/usuarios
        [HttpPost]
        public IActionResult Post(UsuariosDomain novoUsuario)
        {
            // Faz a chamada para o método .Create()
            _usuariosRepository.Create(novoUsuario);

            // Retorna um status code 201 - Create
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um usuario existente
        /// </summary>
        /// <param name="id">id do usuario que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Delete()
            _usuariosRepository.Delete(id);

            // Retorna um status code 204 - No Content
            return StatusCode(204);
        }
    }
}
