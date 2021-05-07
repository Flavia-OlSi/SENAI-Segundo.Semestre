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

        public void AtualizarStatus(int id, int statusAtualizado)
        {
            Consultas consulta = ctx.Consultas.Find(id);

            if (consulta != null)
            {
                consulta.IdSituacao = statusAtualizado;
            }

            ctx.Consultas.Update(consulta);

            ctx.SaveChanges();
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

        public List<Consultas> ListarPorMedico(int idUsuario)
        {

            Medicos medico = ctx.Medicos.FirstOrDefault(x => x.IdUsuario == idUsuario);

            return ctx.Consultas
                .Include(c => c.IdPacienteNavigation)
                .Include(c => c.IdMedicoNavigation)
                .Include(c => c.IdSituacaoNavigation)
                .Where(c => c.IdMedico == medico.IdMedico)
                .ToList();
        }

        public List<Consultas> ListarPorPaciente(int idUsuario)
        {

            Pacientes paciente = ctx.Pacientes.FirstOrDefault(x => x.IdUsuario == idUsuario);

            return ctx.Consultas
                 .Include(c => c.IdPacienteNavigation)
                 .Include(c => c.IdMedicoNavigation)
                 .Include(c => c.IdSituacaoNavigation)
                 .Where(c => c.IdPaciente == paciente.IdPaciente)
                 .ToList();
        }
    }
}
