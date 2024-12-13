using System.ComponentModel.DataAnnotations;

namespace TarefasApi.Dtos.Tarefas;

public class AdicionarTarefaDto
{
    [Required(ErrorMessage = "Título obrigatório!")]
    [Range(5, 500, ErrorMessage = "O Título deve ter entre 5 e 100 caracteres")]

    public string Titulo { get; set; }

    [MaxLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres")]
    public string Descricao { get; set; }

    public bool StatusInicial { get; set; } = true;
}
