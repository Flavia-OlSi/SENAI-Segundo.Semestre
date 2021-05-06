using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Especialidades
    /// </summary>
    public partial class Especialidades
    {
        public Especialidades()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int idEspecialidade { get; set; }

        [Required(ErrorMessage = "O nome da especialidade é obrigatório!")]
        public string Nome { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
