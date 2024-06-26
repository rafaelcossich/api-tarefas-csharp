using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefas.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTarefas.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public HomeView Index()
        {
            return new HomeView
            {
                Mensagem = "Bem Vindo a API de Tarefas",
                Documentacao = "/swagger"
            };
            
        }
    }

}