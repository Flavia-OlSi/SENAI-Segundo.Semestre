using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Usuario novoUsuario)
        {
            // Adiciona este novoUsuario
            ctx.Usuarios.Add(novoUsuario);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.Usuarios.ToList();
        }

        public Usuario ReadId(int id)
        {
            // Retorna o primeiro usuario encontrada para o id informado
            return ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
        }

        public List<TiposDeUsuario> ReadTiposDeUsuario()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
