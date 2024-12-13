using Microsoft.AspNetCore.Mvc;
using TarefasApi.Dtos.Tarefas;
using TarefasApi.Services.Interface;



namespace TarefasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefasService _tarefasService;

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public async Task<IActionResult> AdicionarTarefa([FromBody] AdicionarTarefaDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
             await _tarefasService.AdicionarTarefa(dto);

            return Ok(new {Message = "Tarefa adicionada com sucesso!"});

        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarTarefa(int id, [FromBody] AtualizarTarefaDto atualizarTarefaDto)
        {
          try
            {
                var tarefaPorId = await _tarefasService.BuscarTarefaEspecifica(id);
                await _tarefasService.AtualizarTarefa(atualizarTarefaDto,id);

                return Ok(new { Message = "Tarefa atualizada com sucesso" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarTarefa(int id)
        {
            try
            {
                await _tarefasService.DeletaTarefa(id);
                return Ok(new { Message = "Tarefa excluida" });
            }
        }
    }
}
