using Microsoft.AspNetCore.Mvc;
using Repository.Model.Book;
using Repository.Repositories;
using Repository.ViewModels;

namespace Repository.Controllers;

[ApiController]
[Route("author")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorRepository _authorRepository;
    public AuthorController(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    
    [HttpGet]
    public async Task<List<AuthorModel>> Authors(string name)
    {
      var authors =  await _authorRepository.GetAuthorsAsync(x => x.Name == name);

      return authors.Select(x => new AuthorModel
      {
          Id = x.Id,
          Name = x.Name
      }).ToList();
    }
}