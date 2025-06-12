using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] //EL nombre debe iniciar con mayusculas y no se permite el uso de caracteres especiales como ñ
    public string? Nombre { get; set; }
    [DataType(DataType.Date)]
    [Required]
    public DateTime FechaNacimiento { get; set; }
    [Required]
    public char Sexo { get; set; }
}