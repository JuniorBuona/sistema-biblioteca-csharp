using BibliotecaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private static List<Livro> livros = new List<Livro>();

    [HttpGet]
    public ActionResult<List<Livro>> Get() => livros;

    [HttpPost]
    public ActionResult<Livro> Post(Livro livro)
    {
        livro.Id = livros.Count + 1;
        livros.Add(livro);
        return CreatedAtAction(nameof(Get), new { id = livro.Id }, livro);
    }
}