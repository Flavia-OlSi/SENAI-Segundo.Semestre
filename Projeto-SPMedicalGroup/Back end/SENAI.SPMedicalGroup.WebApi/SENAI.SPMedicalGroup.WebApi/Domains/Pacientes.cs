using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Pacientes
    /// </summary>
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int idPaciente { get; set; }

        [Required(ErrorMessage = "O idUsuario do paciente é obrigatório!")]
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "O nome do paciente é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "a data de nascimento do paciente é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime Data_de_nascimento { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessage = "O RG do paciente é obrigatório!")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O CPF do paciente é obrigatório!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O logradouro do paciente é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número do paciente é obrigatório!")]
        public int Número { get; set; }

        public string Bairro { get; set; }

        [Required(ErrorMessage = "O cidade do paciente é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O UF do paciente é obrigatório!")]
        public string UF { get; set; }
        public string CEP { get; set; }

        public virtual Usuarios idUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
