using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using PlanoFitApi.Dto;
using PlanoFitApi.Models; // Importe o namespace onde UserModel está definido

namespace PlanoFitApi.Controllers.User
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly PlanoFitContext _context;

        public UserController(PlanoFitContext context)
        {
            _context = context;
        }

        [HttpPost(Name = "PostUser")]
        public async Task<IActionResult> CadastroUsuario(CreateUserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            var user = new Models.User
            {
                Email = userDto.Email,
                Nome = userDto.Nome,
                Password = hashedPassword,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("Usuário Cadastrado Com Sucesso!");
        }
    }
}
