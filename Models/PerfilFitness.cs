namespace PlanoFitApi.Models;

using PlanoFitApi.Enums;

public class PerfilFitness
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public int Idade { get; set; }
    public ObjetivoEnum Objetivo { get; set; }
    public string? RestricaoAlimentar { get; set; }
    public DateTime CreatedAt { get; set; }
}
