using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Situacoes
    {
        public Situacoes()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "O status da situação é obrigatório!")]
        public string Status { get; set; }

        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
