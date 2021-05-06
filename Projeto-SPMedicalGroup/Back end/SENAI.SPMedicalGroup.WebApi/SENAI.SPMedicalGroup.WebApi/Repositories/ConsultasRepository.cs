using Microsoft.EntityFrameworkCore;
using SENAI.SPMedicalGroup.WebApi.Contexts;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Repositories
{
    public class ConsultasRepository : IConsultasRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamdos os métodos do EF Core
        /// </summary>
        SPMedicalGroupContext ctx = new SPMedicalGroupContext();

        public void AtualizaDescricao(int id, string descricaoAtualizada)
        {
            Consultas consulta = ctx.Consultas.Find(id);

            if (consulta != null)
            {
                consulta.Descricao = descricaoAtualizada;
            }

            ctx.Consultas.Update(consulta);

            ctx.SaveChanges();
        }

        public void AtualizaDescricao(int id, Consultas descricaoAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatus(int id, string statusAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consultas novaConsulta)
        {
            ctx.Consultas.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public List<Consultas> Listar()
        {
            return ctx.Consultas.ToList();
        }

        public List<Consultas> ListarPorMedico(int id)
        {
            return ctx.Consultas
                .Include(c => c.idPacienteNavigation)
                .Include(c => c.idMedicoNavigation)
                .Include(c => c.idSituacaoNavigation)
                .Where(c => c.idMedico == id)
                .ToList();
        }

        public List<Consultas> ListarPorPaciente(int id)
        {
            return ctx.Consultas
                 .Include(c => c.idPacienteNavigation)
                 .Include(c => c.idMedicoNavigation)
                 .Include(c => c.idSituacaoNavigation)
                 .Where(c => c.idPaciente == id)
                 .ToList();
        }
    }
}
