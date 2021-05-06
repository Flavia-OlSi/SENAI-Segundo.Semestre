using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI_filmes_webApi.Domains;
using SENAI_filmes_webApi.Interfaces;
using SENAI_filmes_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controler responsável pelos endpoints (URLs) referentes aos gêneros
/// </summary>
namespace SENAI_filmes_webApi.Controllers
{
    // Define que o tipo de API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será formato dominio/api/nomeController
    // ex: http://localhost:5000/api/Generos
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class GenerosController : ControllerBase
    {
        /// <summary>
        /// Objeto _generoRepository que irá receber todos os métodos definidos na interface IGeneroRepository
        /// </summary>
        // Comum nomear objetos que chamam métodos com _ na frente
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _generoRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }


        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gêneros e um status code</returns>
        /// dominio/api/generos
        [HttpGet]
        // O nome Get pode ser modificado por qualquer outro
        public IActionResult Get()
        {
            // Cria uma lista nomeada listaGeneros para receber os dados
            List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

            // Retorna o status code 200 (Ok) com a lista de gêneros no formato JSON
            return Ok(listaGeneros);
        }

        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto novoGenero recebido na requisão</param>
        /// <returns>Um status code 201 - Created</returns>
        /// http://localhost:5000/api/generos
        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            // Faz a chamada para o método .Cadastrar()
            _generoRepository.Cadastrar(novoGenero);

            // Retorna status code 201 - Created
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um gênero existente
        /// </summary>
        /// <param name="id">id di gênero quue será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar()
            _generoRepository.Deletar(id);

            //  Retorna status code 204 - No Content
            return StatusCode(204);
        }
    }
}
