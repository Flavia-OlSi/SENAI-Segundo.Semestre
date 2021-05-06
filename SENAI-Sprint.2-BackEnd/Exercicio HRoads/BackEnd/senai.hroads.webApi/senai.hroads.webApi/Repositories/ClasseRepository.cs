using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClasseRepository : IClasseRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Classe novaClasse)
        {
            // Adiciona esta novaClasse
            ctx.Classes.Add(novaClasse);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Classe> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.Classes.ToList();
        }

        public Classe ReadId(int id)
        {
            // Retorna a primeira classe encontrada para o id informado
            return ctx.Classes.FirstOrDefault(x => x.IdClasse == id);
        }

        public void Update(int id, Classe classeAtualizada)
        {
            
        }
    }
}
