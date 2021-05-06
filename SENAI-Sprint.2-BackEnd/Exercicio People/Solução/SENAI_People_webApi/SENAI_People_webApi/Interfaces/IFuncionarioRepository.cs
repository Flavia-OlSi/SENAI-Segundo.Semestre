using SENAI_People_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_People_webApi.Interfaces
{
    interface IFuncionarioRepository
    {
        /// <summary>
        /// Lista todos os funcionários
        /// </summary>
        /// <returns>Retorna uma lista de funcionários</returns>
        List<FuncionarioDomain> Listar();

        /// <summary>
        /// Busca um funcionário pelo ID
        /// </summary>
        /// <param name="id">ID do funcionário que será buscado</param>
        /// <returns>Retorna o funcionário buscado conforme o id</returns>
        FuncionarioDomain BuscarPorId(int id);

        /// <summary>
        /// Insere/cadastra um novo funcionario
        /// </summary>
        /// <param name="novoFuncionario">Objeto novoFuncionario que será inserido/cadastrado</param>
        void Inserir(FuncionarioDomain novoFuncionario);

        /// <summary>
        /// Atualiza um funcionário existente
        /// </summary>
        /// <param name="id">ID do funcionário que será atualizado</param>
        /// <param name="funcionarioAtualizado">Objeto funcionarioAtualizado que será atualizado</param>
        void Atualizar(int id, FuncionarioDomain funcionarioAtualizado);

        /// <summary>
        /// Deleta um funcionário
        /// </summary>
        /// <param name="id">ID do funcionário que será deletado</param>
        void Deletar(int id);

        /// <summary>
        /// Busca funcionários pelo nome
        /// </summary>
        /// <param name="nome">Objeto nome que será buscado</param>
        /// <returns>Retorna uma lista de funcionários com o nome especifico buscado</returns>
        List<FuncionarioDomain> BuscarPorNome(string nome);

        /// <summary>
        /// Lista os funcionários de forma que retorne seus nomes completos
        /// </summary>
        /// <returns>Retorna uma lista de funcionários</returns>
        List<FuncionarioDomain> ListarNomeCompleto();

        /// <summary>
        /// Lista os funcionários de maneira ordenada
        /// </summary>
        /// <param name="ordem">String que define a ordenação</param>
        /// <returns>Retorna uma lista ordenada de de funcionários</returns>
        List<FuncionarioDomain> ListarPorOrdem(string ordem);

    }
}
