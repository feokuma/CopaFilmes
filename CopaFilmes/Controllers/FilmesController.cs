using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CopaFilmes.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CopaFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FilmesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: api/Filmes
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://copadosfilmes.azurewebsites.net");
            string result = await client.GetStringAsync("/api/filmes");
            
            return Ok(JsonConvert.DeserializeObject<IEnumerable<Filme>>(result));
        }

        // POST: api/Filmes
        [HttpPost]
        public IActionResult Post([FromBody] IEnumerable<Filme> filmes)
        {
            if(filmes.Count() < 8)
                return BadRequest();

            var orderedList =  filmes.OrderBy(filme => filme.Titulo);
            return Ok(orderedList);
        }


    }
}
