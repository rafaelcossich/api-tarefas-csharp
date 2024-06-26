using ApiTarefas.Database;
using ApiTarefas.Dto;
using ApiTarefas.Models;
using ApiTarefas.Models.Erro;

namespace ApiTarefas.Servicos.Interfaces
{
    public interface ITarefaServico
    {
        List<Tarefa> Lista(int page);

        Tarefa Incluir(TarefaDto tarefaDto);


        Tarefa Update(int id, TarefaDto tarefaDto);


        Tarefa SearchId(int id);

        void Delete(int id);
    }
}