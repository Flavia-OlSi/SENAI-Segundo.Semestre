﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Estudios
    /// </summary>
    public class EstudiosDomain
    {
        public int idEstudio { get; set; }

        [Required(ErrorMessage = "Informe o nome do estúdio")]
        public string nomeEstudio { get; set; }
    }
}
