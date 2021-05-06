using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public string Nome { get; set; }
        public int CapacidadeMaximaVida { get; set; }
        public int CapacidadeMaximaMana { get; set; }
        public DateTime DataDeAtualização { get; set; }
        public DateTime DataDeCriação { get; set; }
        public int? IdClasse { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
