using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Jogos
    /// </summary>
    public class JogosDomain
    {
        public int idJogo { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string nomeJogo { get; set; }
        public string descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataLancamento { get; set; }

        [Required(ErrorMessage = "Informe o valor do jogo")]
        public decimal valor { get; set; }
        public int idEstudio { get; set; }
    }
}
