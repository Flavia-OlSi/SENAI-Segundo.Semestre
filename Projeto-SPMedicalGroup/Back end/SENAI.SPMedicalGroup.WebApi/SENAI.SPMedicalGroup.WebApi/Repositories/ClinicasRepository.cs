﻿using SENAI.SPMedicalGroup.WebApi.Contexts;
using SENAI.SPMedicalGroup.WebApi.Domains;
using SENAI.SPMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Repositories
{
    public class ClinicasRepository : IClinicasRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamdos os métodos do EF Core
        /// </summary>
        SPMedicalGroupContext ctx = new SPMedicalGroupContext();

        public void Cadastrar(Clinicas novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }
    }
}
