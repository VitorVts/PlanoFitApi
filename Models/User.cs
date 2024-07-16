namespace PlanoFitApi.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
