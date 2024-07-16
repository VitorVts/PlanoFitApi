namespace PlanoFitApi.Models;

public class Plano
{
    public int Id { get; set; }
    public int PerfilId { get; set; }
    public string Dieta { get; set; }
    public string Treino { get; set; }
    public DateTime CreatedAt { get; set; }
}
