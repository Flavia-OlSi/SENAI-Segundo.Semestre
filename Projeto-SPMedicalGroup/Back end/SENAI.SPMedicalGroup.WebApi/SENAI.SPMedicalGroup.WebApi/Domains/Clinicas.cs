using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Clinicas
    {
        public Clinicas()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdClinica { get; set; }

        [Required(ErrorMessage = "O nome da clínica é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CNPJ da clínica é obrigatório!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "A razão social da clínica é obrigatório!")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O logradouro da clínica é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número da clínica é obrigatório!")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "A cidade da clínica é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O UF da clínica é obrigatório!")]
        public string Uf { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
