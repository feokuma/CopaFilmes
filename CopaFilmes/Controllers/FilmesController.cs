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
            return Ok(SortFilmes(filmes));
        }

        public static IEnumerable<Filme> SortFilmes(IEnumerable<Filme> originalList)
        {
            // sort list using name of movie
            var orderedList = originalList.OrderBy(filme => filme.titulo).ToList();

            //create a new list to build the challenge list
            List<Filme> challangeList = new List<Filme>();

            //loop to build the result list
            while(orderedList.Count() > 1)
            {
                // add items to a new list
                challangeList.Add(orderedList.First());
                challangeList.Add(orderedList.Last());

                // remove items from the ordered list
                orderedList.Remove(orderedList.Last());
                orderedList.Remove(orderedList.First());
            }

            // return the challange list
            return challangeList;
        }


    }
}
