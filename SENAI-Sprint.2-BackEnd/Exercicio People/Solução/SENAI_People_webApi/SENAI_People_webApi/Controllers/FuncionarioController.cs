using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI_People_webApi.Domains;
using SENAI_People_webApi.Interfaces;
using SENAI_People_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_People_webApi.Controllers
{
    /// <summary>
    /// Define que a resposta será em JSON
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        /// <summary>
        /// Objeto _funcionarioRepository que irá receber todos os métodos definidos na interface IFuncionarioRepository
        /// </summary>
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_funcionarioRepository.Listar());
        }


        [HttpGet("nomeCompleto")]
        public IActionResult GetFullName()
        {

            return Ok(_funcionarioRepository.ListarNomeCompleto());
        }
    }
}
