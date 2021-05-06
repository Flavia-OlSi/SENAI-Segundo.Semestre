using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TiposDeHabilidadeRepository : ITiposDeHabilidadeRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(TiposDeHabilidade novoTipoDeHabilidade)
        {
            // Adiciona este novoTipoDeHabilidade
            ctx.TiposDeHabilidades.Add(novoTipoDeHabilidade);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposDeHabilidade> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.TiposDeHabilidades.ToList();
        }

        public TiposDeHabilidade ReadId(int id)
        {
            // Retorna o primeiro tipo de habilidade encontrada para o id informado
            return ctx.TiposDeHabilidades.FirstOrDefault(x => x.IdTipoDeHabilidade == id);
        }

        public void Update(int id, TiposDeHabilidade tipoDeHabilidadeAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
