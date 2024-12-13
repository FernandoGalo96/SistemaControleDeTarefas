using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TarefasApi.Data;
using TarefasApi.Dtos.Tarefas;
using TarefasApi.Models;
using TarefasApi.Services.Interface;

namespace TarefasApi.Services;

public class TarefasService : ITarefasService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public TarefasService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task AdicionarTarefa(AdicionarTarefaDto tarefaDto)
    {
       

        Tarefas tarefas = _mapper.Map<Tarefas>(tarefaDto);

        if (tarefas == null) throw new Exception("tarefas nulas");
        _context.Tarefa.Add(tarefas);
        await _context.SaveChangesAsync();
         
    }

    public async Task AtualizarTarefa(AtualizarTarefaDto atualizarTarefa,int id)
    {
        var tarefa = await BuscarTarefaEspecifica(id);

        if (atualizarTarefa == null) throw new Exception("Error");
        _mapper.Map(atualizarTarefa, tarefa);
        await _context.SaveChangesAsync();

    }

   
    public async Task<List<Tarefas>> RecuperarTodasTarefas()
    {
        return await _context.Tarefa.OrderBy(c => c.DataCriacao).ToListAsync();
    }

    
    public async Task DeletaTarefa(int id)
    {


        var tarefa = await BuscarTarefaEspecifica(id);
        if (tarefa == null) throw new Exception("Id não localizado");
        
        _context.Tarefa.Remove(tarefa);

        await _context.SaveChangesAsync();
    }

    public async Task<Tarefas> BuscarTarefaEspecifica(int id)
    {
        var tarefaId = await _context.Tarefa.FirstOrDefaultAsync(t => t.Id == id);

        if (tarefaId == null) throw new Exception("Tarefa não encontrada");

        return tarefaId;
    }

    public async Task<List<Tarefas>> RecuperarTarefasPorStatus(string status)
    {
        if (status == null) throw new Exception("Status não encontrado");

        return await _context.Tarefa.Where( s => s.StatusInicial.Equals(status)).OrderBy(c =>  c.StatusInicial).ToListAsync();
    }


   

}
