using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefas.Dto;
using ApiTarefas.Database;
using ApiTarefas.Models;
using ApiTarefas.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiTarefas.Servicos;
using ApiTarefas.Models.Erro;
using Microsoft.VisualBasic;
using ApiTarefas.Servicos.Interfaces;

namespace ApiTarefas.Controllers
{
    [ApiController]
    [Route("/tarefas")]
    public class TarefasController : ControllerBase
    {

        public TarefasController(ITarefaServico servico)
        {
            _servico = servico;
        }

        private ITarefaServico _servico;

        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            var tarefas = _servico.Lista(page);
            return StatusCode(200, tarefas);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TarefaDto tarefaDto)
        {
            try
            {
                var tarefa = _servico.Incluir(tarefaDto);
                return StatusCode(201, tarefa);
            }
            catch(TarefaErro erro)
            {
                return StatusCode(400, new ErrorView { Mensagem = erro.Message });
            }
            
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] TarefaDto tarefaDto)
        {
            try
            {
                var tarefa = _servico.Update(id, tarefaDto);
                return StatusCode(200, tarefa);
            }
            catch(TarefaErro erro)
            {
                return StatusCode(400, new ErrorView { Mensagem = erro.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Show([FromRoute] int id)
        {
            var tarefaDb = _servico.SearchId(id);
            try
            {
                var tarefa = _servico.SearchId(id);
                return StatusCode(201, tarefaDb);
            }
            catch(TarefaErro erro)
            {
                return StatusCode(404, new ErrorView { Mensagem = erro.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _servico.Delete(id);
                return StatusCode(204);
            }
            catch(TarefaErro erro)
            {
                return StatusCode(404, new ErrorView { Mensagem = erro.Message });
            }
        }
    }

}