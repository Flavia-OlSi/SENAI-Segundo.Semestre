using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Clinicas
    /// </summary>
    public partial class Clinicas
    {
        public Clinicas()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int idClinica { get; set; }

        [Required(ErrorMessage = "O nome da clínica é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CNPJ da clínica é obrigatório!")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "A razão social da clínica é obrigatório!")]
        public string Razão_social { get; set; }

        [Required(ErrorMessage = "O logradouro da clínica é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número da clínica é obrigatório!")]
        public int Número { get; set; }

        [Required(ErrorMessage = "A cidade da clínica é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O UF da clínica é obrigatório!")]
        public string UF { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
