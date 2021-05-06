using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Consultas
    /// </summary>
    public partial class Consultas
    {
        public int idConsulta { get; set; }

        [Required(ErrorMessage = "O idPaciente da consulta é obrigatório!")]
        public int idPaciente { get; set; }

        [Required(ErrorMessage = "O idMedico da consulta é obrigatório!")]
        public int idMedico { get; set; }

        public int idSituacao { get; set; }

        public int Descricao { get; set; }

        [Required(ErrorMessage = "A data da consulta é obrigatório!")]
        public DateTime Data { get; set; }

        public virtual Medicos idMedicoNavigation { get; set; }
        public virtual Pacientes idPacienteNavigation { get; set; }
        public virtual Situacoes idSituacaoNavigation { get; set; }
    }
}
