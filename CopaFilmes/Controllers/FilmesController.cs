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
            // get the reference to httpclient service
            _httpClientFactory = httpClientFactory;
        }

        // GET: api/Filmes
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            // create a httpclient to consume Filmes API
            var client = _httpClientFactory.CreateClient();
            // set base address of API
            client.BaseAddress = new Uri("https://copadosfilmes.azurewebsites.net");
            // set the route to API
            string result = await client.GetStringAsync("/api/filmes");
            
            // return then list of movies
            return Ok(JsonConvert.DeserializeObject<IEnumerable<Filme>>(result));
        }

        // POST: api/Filmes
        [HttpPost]
        public IActionResult Post([FromBody] IEnumerable<Filme> filmes)
        {
            // organize the list by names
            var resultList = SortFilmes(filmes);

            // execute until 2 movies on the list
            while(resultList.Count() > 2)
                resultList = ExecuteChallanges(resultList);

            // return the result list
            return Ok(resultList);
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

        public static IEnumerable<Filme> ExecuteChallanges(IEnumerable<Filme> listFilmes)
        {
            // convert the IEnumerable to List
            var originalList = listFilmes.ToList();
            // list to build the result list
            List<Filme> resultList = new List<Filme>();

            // verify if this is not be the final 
            if (originalList.Count() > 2)
            {
                // loop to do all the challanges
                while (originalList.Count() > 0)
                {
                    // execute the battle
                    resultList.Add((originalList[0].nota * 10) >= (originalList[1].nota * 10) ? originalList[0] : originalList[1]);
                    // remove the movies
                    originalList.RemoveAt(0);
                    originalList.RemoveAt(0);
                }
            }
            else
            {
                // return both
                resultList = originalList.OrderByDescending(filme => filme.nota).ToList();
            }

            // return the list of winners
            return resultList;
        }
    }
}
