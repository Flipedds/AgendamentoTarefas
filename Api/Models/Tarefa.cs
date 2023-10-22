using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    [Required]
    public string Titulo { get; set; }

    [MaxLength(250)]
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    
    [Required]
    public EnumStatusTarefa Status { get; set; }
}
