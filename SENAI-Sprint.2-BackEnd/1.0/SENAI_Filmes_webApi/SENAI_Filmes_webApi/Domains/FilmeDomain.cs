using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_Filmes_webApi.Domains
{
    public class FilmeDomain
    {
        public int idFilme { get; set; }

        public string titulo { get; set; }

        public int idGenero { get; set; }
    }
}
