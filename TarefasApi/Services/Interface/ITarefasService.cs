using TarefasApi.Dtos.Tarefas;
using TarefasApi.Models;

namespace TarefasApi.Services.Interface;

public interface ITarefasService
{
    Task AdicionarTarefa(AdicionarTarefaDto tarefaDto);

    Task<List<Tarefas>> RecuperarTodasTarefas();



    Task AtualizarTarefa(AtualizarTarefaDto atualizarTarefa, int id);

    Task DeletaTarefa(int id);

    Task<Tarefas> BuscarTarefaEspecifica(int id);

    Task<List<Tarefas>> RecuperarTarefasPorStatus (string status);  
}
