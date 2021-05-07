using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipo { get; set; }

        [Required(ErrorMessage = "A identificação do tipo de usuario é obrigatório!")]
        public string Identicacao { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
