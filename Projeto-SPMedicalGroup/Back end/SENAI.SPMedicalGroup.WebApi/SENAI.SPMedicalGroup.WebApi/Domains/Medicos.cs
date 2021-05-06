using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Medicos
    /// </summary>
    public partial class Medicos
    {
        public Medicos()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int idMedico { get; set; }

        [Required(ErrorMessage = "O idEspecialidade do medico é obrigatório!")]
        public int idEspecialidade { get; set; }

        [Required(ErrorMessage = "O idClinica do medico é obrigatório!")]
        public int idClinica { get; set; }

        [Required(ErrorMessage = "O idUsuario do medico é obrigatório!")]
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "O CRM do medico é obrigatório!")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "O nome do medico é obrigatório!")]
        public string Nome { get; set; }

        public virtual Clinicas idClinicaNavigation { get; set; }
        public virtual Especialidades idEspecialidadeNavigation { get; set; }
        public virtual Usuarios idUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
