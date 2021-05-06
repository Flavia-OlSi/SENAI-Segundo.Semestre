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
    // ex: http://localhost:5000/api/Estudios
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        /// <summary>
        /// Objeto _estudiosRepository que irá receber todos os métodos definidos na interface IEstudiosRepository
        /// </summary>
        private IEstudiosRepository _estudiosRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _estudiosRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public EstudiosController()
        {
            _estudiosRepository = new EstudiosRepository();
        }

        /// <summary>
        /// Lista todos os estudios
        /// </summary>
        /// <returns>Uma lista de estudios e um status code</returns>
        /// dominio/api/estudios
        [HttpGet]
        public IActionResult GetAll()
        {
            // Cria uma lista nomeada listaEstudios para receber os dados
            List<EstudiosDomain> listaEstudios = _estudiosRepository.ReadAll();

            // Retorna o status code 200 (Ok) com a lista de estudios no formato JSON
            return Ok(listaEstudios);
        }

        /// <summary>
        /// Busca um estudio através do seu id
        /// </summary>
        /// <returns>Um estudio buscado ou NotFound caso nenhum estudio seja encontrado</returns>
        /// http://localhost:5000/api/estudios/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Cria um objeto que irá receber o estudio no banco de dados
            EstudiosDomain estudio = _estudiosRepository.Read(id);

            if (estudio == null)
            {
                // Caso não seja encontrado, retorna um status code 404 - Not Found com a mensagem personalizada
                return NotFound("Nenhum estudio foi encontrado");
            }

            // Caso seja encontrado, retorna o que foi solicitado com um status code 200 - Ok
            return Ok(estudio);
        }

        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio recebido na requisição</param>
        /// <returns>um status code 201 - Create</returns>
        /// http://localhost:5000/api/estudios
        [HttpPost]
        public IActionResult Post(EstudiosDomain novoEstudio)
        {
            // Faz a chamada para o método .Create()
            _estudiosRepository.Create(novoEstudio);

            // Retorna um status code 201 - Create
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um estudio existente
        /// </summary>
        /// <param name="id">id do estudio que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Delete()
            _estudiosRepository.Delete(id);
            
            // Retorna um status code 204 - No Content
            return StatusCode(204);
        }
    }
}
