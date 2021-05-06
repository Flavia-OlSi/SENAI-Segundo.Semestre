using SENAI_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_filmes_webApi.Interfaces
{
    public interface IFilmeRepository
    {
        // TipoRetorno NomeMetodo(TipoParametro parametro);
        // void Cadastrar();

        /// <summary>
        /// Retornar todos os filmes
        /// </summary>
        /// <returns>Uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Busca um filmes através do seu id
        /// </summary>
        /// <param name="id">id do filme que será buscado</param>
        /// <returns>Um objeto do tipo FilmeDomain que foi buscado</returns>
        FilmeDomain BuscarPorId(int id);

        /// <summary>
        /// Cadastro um novo filme
        /// </summary>
        /// <param name="novoGenero">Objeto novoFilme que será cadastrado</param>
        void Cadastrar(FilmeDomain novoFilme);

        /// <summary>
        /// Atualiza um filme existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Objeto filme que será atualizado</param>
        void AtualizarIdCorpo(FilmeDomain filme);

        /// <summary>
        /// atualiza um filme existente passando o id pela url da requisição
        /// </summary>
        /// <param name="id">id do filme que será atualizado</param>
        /// <param name="genero">Objeto filme com as novas informações</param>
        void AtualizarIdUrl(int id, FilmeDomain filme);

        /// <summary>
        /// Deleta um filme
        /// </summary>
        /// <param name="id">id do filme que será deletado</param>
        void Deletar(int id);
    }
}
