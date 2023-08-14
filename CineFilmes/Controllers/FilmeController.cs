using CineFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Genero);
            Console.WriteLine(filme.Duracao);
        }
    }
}
