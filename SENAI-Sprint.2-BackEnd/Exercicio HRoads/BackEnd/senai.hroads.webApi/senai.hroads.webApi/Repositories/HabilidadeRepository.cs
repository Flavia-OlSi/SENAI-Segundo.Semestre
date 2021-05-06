using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Habilidade novaHabilidade)
        {
            // Adiciona esta novaHabilidade
            ctx.Habilidades.Add(novaHabilidade);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Habilidade> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.Habilidades.ToList();
        }

        public List<ClasseHabilidade> ReadClasseHabilidade()
        {
            throw new NotImplementedException();
        }

        public Habilidade ReadId(int id)
        {
            // Retorna a primeira habilidade encontrada para o id informado
            return ctx.Habilidades.FirstOrDefault(x => x.IdHabilidades == id);
        }

        public void Update(int id, Habilidade habilidadeAtualizada)
        {
            throw new NotImplementedException();
        }
    }
}
