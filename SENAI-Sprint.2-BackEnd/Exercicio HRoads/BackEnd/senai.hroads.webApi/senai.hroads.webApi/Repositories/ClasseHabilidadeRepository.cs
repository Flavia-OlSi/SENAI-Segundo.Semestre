using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClasseHabilidadeRepository : IClasseHabilidadeRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(ClasseHabilidade novaClasseHabilidade)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClasseHabilidade> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.ClasseHabilidades.ToList();
        }

        public List<Classe> ReadClasse()
        {
            // Retorna uma lista com todas as informações
            return ctx.Classes.ToList();
        }

        public List<Habilidade> ReadHabilidade()
        {
            // Retorna uma lista com todas as informações
            return ctx.Habilidades.ToList();
        }

        public ClasseHabilidade ReadId(int id)
        {
            // Retorna a primeira classe habilidade encontrada para o id informado
            return ctx.ClasseHabilidades.FirstOrDefault(x => x.IdClasse == id);
        }

        public void Update(int id, ClasseHabilidade classeHabilidadeAtualizada)
        {
            throw new NotImplementedException();
        }
    }
}
