using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidades { get; set; }
        public string Nome { get; set; }
        public int IdTipoDeHabilidade { get; set; }

        public virtual TiposDeHabilidade IdTipoDeHabilidadeNavigation { get; set; }
    }
}
