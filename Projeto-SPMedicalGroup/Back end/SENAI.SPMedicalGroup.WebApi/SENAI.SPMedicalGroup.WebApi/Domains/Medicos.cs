using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Medicos
    {
        public Medicos()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int IdMedico { get; set; }

        [Required(ErrorMessage = "O idEspecialidade do medico é obrigatório!")]
        public int IdEspecialidade { get; set; }

        [Required(ErrorMessage = "O idClinica do medico é obrigatório!")]
        public int IdClinica { get; set; }

        [Required(ErrorMessage = "O idUsuario do medico é obrigatório!")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O CRM do medico é obrigatório!")]
        public string Crm { get; set; }

        [Required(ErrorMessage = "O nome do medico é obrigatório!")]
        public string Nome { get; set; }

        public virtual Clinicas IdClinicaNavigation { get; set; }
        public virtual Especialidades IdEspecialidadeNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
