using SENAI.SPMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ConsultasRepository
    /// </summary>
    interface IConsultasRepository
    {
        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="novaConsulta">Objeto novaConsulta que será cadastrada</param>
        void Cadastrar(Consultas novaConsulta);


        /// <summary>
        /// Atualiza os status da consulta
        /// </summary>
        /// <param name="id">id da consulta que será atualizada</param>
        /// <param name="statusAtualizado">Objeto status atualizado que será atualizado</param>
        void AtualizarStatus(int id, string statusAtualizado);

        /// <summary>
        /// Atualiza a descrição da consulta
        /// </summary>
        /// <param name="id">id da consulta que será atualizada</param>
        /// <param name="descricaoAtualizada">Objeto descrição que será atualizada</param>
        void AtualizaDescricao(int id, Consultas descricaoAtualizada);

        /// <summary>
        /// Lista todas as consultas
        /// </summary>
        /// <returns>Uma lista de consultas</returns>
        List<Consultas> Listar();

        /// <summary>
        /// Lista todas as consultas por paciente
        /// </summary>
        /// <param name="id">Objeto idPaciente que identifica o paciente desejado</param>
        /// <returns>Uma lista de consultas de um paciente</returns>
        List<Consultas> ListarPorPaciente(int id);

        /// <summary>
        /// Lista todas as consultas por medico
        /// </summary>
        /// <param name="id">Objeto idMedico que identifica o medico desejado</param>
        /// <returns>Uma lista de consultas de um médico</returns>
        List<Consultas> ListarPorMedico(int id);

    }
}
