using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "O idUsuario do paciente é obrigatório!")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome do paciente é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "a data de nascimento do paciente é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessage = "O RG do paciente é obrigatório!")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O CPF do paciente é obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O logradouro do paciente é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número do paciente é obrigatório!")]
        public int Numero { get; set; }

        public string Bairro { get; set; }

        [Required(ErrorMessage = "O cidade do paciente é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O UF do paciente é obrigatório!")]
        public string Uf { get; set; }

        public string Cep { get; set; }


        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
