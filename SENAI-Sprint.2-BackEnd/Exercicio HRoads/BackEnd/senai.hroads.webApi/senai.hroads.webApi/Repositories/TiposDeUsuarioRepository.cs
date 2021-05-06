using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TiposDeUsuarioRepository : ITiposDeUsuarioRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(TiposDeUsuario novoTipoDeUsuario)
        {
            // Adiciona este novoTipoDeUsuario
            ctx.TiposDeUsuarios.Add(novoTipoDeUsuario);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposDeUsuario> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.TiposDeUsuarios.ToList();
        }

        public TiposDeUsuario ReadId(int id)
        {
            // Retorna o primeiro tipo de usuario encontrada para o id informado
            return ctx.TiposDeUsuarios.FirstOrDefault(x => x.IdTipoDeUsuario == id);
        }

        public void Update(int id, TiposDeUsuario tipoDeUsuarioAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
