using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Usuarios
    /// </summary>
    public class UsuariosDomain
    {
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int idTipoUsurio { get; set; }
    }
}
