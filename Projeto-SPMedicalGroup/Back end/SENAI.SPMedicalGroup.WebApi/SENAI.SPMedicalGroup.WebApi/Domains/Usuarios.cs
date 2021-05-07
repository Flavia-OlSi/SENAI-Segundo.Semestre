using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Medicos = new HashSet<Medicos>();
            Pacientes = new HashSet<Pacientes>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O idTipo do usuario é obrigatório!")]
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "O email do usuario é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha do usuario é obrigatório!")]
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoNavigation { get; set; }
        public virtual ICollection<Medicos> Medicos { get; set; }
        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
