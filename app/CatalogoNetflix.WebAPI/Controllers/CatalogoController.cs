using CatalogoNetflix.WebAPI.Data.Entities;
using CatalogoNetflix.WebAPI.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoController : ControllerBase
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly FilmeRepository _filmeRepository;

        public CatalogoController(ILogger<CatalogoController> logger, FilmeRepository filmeRepository)
        {
            _logger = logger;
            _filmeRepository = filmeRepository;
        }

        [HttpGet]
        public IEnumerable<Filme> Get() => _filmeRepository.GetAll();

        [HttpGet]
        [Route("{id}")]
        public Filme GetById(int id) => _filmeRepository.GetById(id);

        [HttpGet]
        [Route("search/{title}")]
        public IEnumerable<Filme> GetByTitle(string title) => _filmeRepository.Search(x => x.Title.ToLower().Contains(title.ToLower()));

        [HttpPost]
        public async Task<IEnumerable<Filme>> Post(List<Filme> filmes)
        {
            List<Filme> filmesParaSalvar = new List<Filme>();

            foreach (var filme in filmes)
            {
                if (!_filmeRepository.Search(x => x.Title == filme.Title && x.ReleaseYear == filme.ReleaseYear).Any())
                    filmesParaSalvar.Add(filme);
            }

            var result = await _filmeRepository.AddOrUpdateRangeAsync(filmesParaSalvar);

            return result;
        }
    }
}
