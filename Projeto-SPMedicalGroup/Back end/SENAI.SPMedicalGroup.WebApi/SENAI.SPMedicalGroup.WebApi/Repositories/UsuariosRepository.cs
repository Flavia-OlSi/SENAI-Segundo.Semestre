using SENAI.SPMedicalGroup.WebApi.Contexts;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamdos os métodos do EF Core
        /// </summary>
        SPMedicalGroupContext ctx = new SPMedicalGroupContext();

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public Usuarios Login(string email, string senha)
        {
            // Retorna o usuário encontrado atráves do e-mail e da senha
            return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}
