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
    // ex: http://localhost:5000/api/Jogos
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class JogosController : ControllerBase
    {
        /// <summary>
        /// Objeto _jogosRepository que irá receber todos os métodos definidos na interface IJogosRepository
        /// </summary>
        private IJogosRepository _jogosRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _jogosRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public JogosController()
        {
            _jogosRepository = new JogosRepository();
        }

        /// <summary>
        /// Lista todos os jogos
        /// </summary>
        /// <returns>Uma lista de jogos e um status code</returns>
        /// dominio/api/jogos
        [HttpGet]
        public IActionResult GetAll()
        {
            // Cria uma lista nomeada listaJogos para receber os dados
            List<JogosDomain> listaJogos = _jogosRepository.ReadAll();

            // Retorna o status code 200 (Ok) com a lista de jogos no formato JSON
            return Ok(listaJogos);
        }

        /// <summary>
        /// Busca um jogo através do seu od
        /// </summary>
        /// <returns>Um jogo buscado ou NotFound caso nenhum jogo seja encontrado</returns>
        /// http://localhost:5000/api/jogos/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Cria um objeto que irá receber o jogo no banco de dados
            JogosDomain jogo = _jogosRepository.Read(id);

            if (jogo == null)
            {
                // Caso não seja encontrado, retorna um status code 404 - Not Found com a mensagem personalizada
                return NotFound("Nenhum jogo foi encontrado");
            }

            // Caso seja encontrado, retorna o que foi solicitado com um status code 200 - Ok
            return Ok(jogo);
        }

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="novoJogo">Objeto novoJogo recebido na requisição</param>
        /// <returns>um status code 201 - Create</returns>
        /// http://localhost:5000/api/jogos
        [HttpPost]
        public IActionResult Post(JogosDomain novoJogo)
        {
            // Faz a chamada para o método .Create()
            _jogosRepository.Create(novoJogo);

            // Retorna um status code 201 - Create
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um jogo existente
        /// </summary>
        /// <param name="id">id do jogo que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Delete()
            _jogosRepository.Delete(id);

            // Retorna um status code 204 - No Content
            return StatusCode(204);
        }
    }
}

