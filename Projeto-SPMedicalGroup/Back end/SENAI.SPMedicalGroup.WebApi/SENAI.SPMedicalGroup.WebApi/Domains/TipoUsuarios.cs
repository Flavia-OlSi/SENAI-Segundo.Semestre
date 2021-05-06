using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade TipoUsuarios
    /// </summary>
    public partial class TipoUsuarios
    {
        public TipoUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int idTipo { get; set; }

        [Required(ErrorMessage = "A identificação do tipo de usuario é obrigatório!")]
        public string Identificação { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
