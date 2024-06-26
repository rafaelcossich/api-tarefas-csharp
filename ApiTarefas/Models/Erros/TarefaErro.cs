namespace ApiTarefas.Models.Erro;
 public class TarefaErro : Exception 
 {
    public TarefaErro ( string message) : base (message){}
 }