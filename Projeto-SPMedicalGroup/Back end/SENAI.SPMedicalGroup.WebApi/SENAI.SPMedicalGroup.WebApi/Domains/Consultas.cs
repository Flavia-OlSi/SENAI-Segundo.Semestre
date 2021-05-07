using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Consultas
    {
        public int IdConsulta { get; set; }

        [Required(ErrorMessage = "O idPaciente da consulta é obrigatório!")]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "O idMedico da consulta é obrigatório!")]
        public int IdMedico { get; set; }

        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "A data da consulta é obrigatório!")]
        public DateTime DataDeConsulta { get; set; }

        public string Descricao { get; set; }

        public virtual Medicos IdMedicoNavigation { get; set; }
        public virtual Pacientes IdPacienteNavigation { get; set; }
        public virtual Situacoes IdSituacaoNavigation { get; set; }
    }
}
