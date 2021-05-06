using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Personagem novoPersonagem)
        {
            // Adiciona este novoPersonagem
            ctx.Personagens.Add(novoPersonagem);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Personagem> Read()
        {
            // Retorna uma lista com todas as informações
            return ctx.Personagens.ToList();
        }

        public List<Classe> ReadClasse()
        {
            throw new NotImplementedException();
        }

        public Personagem ReadId(int id)
        {
            // Retorna o primeiro personagem encontrada para o id informado
            return ctx.Personagens.FirstOrDefault(x => x.IdPersonagem == id);
        }

        public List<Usuario> Readusuario()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Personagem personagemAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
