using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.ModelViews
{
    public struct HomeView
    {
        public required string Mensagem { get; set; }
        public required string Documentacao { get; set; }
    }
}