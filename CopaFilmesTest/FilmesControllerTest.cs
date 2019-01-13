using CopaFilmes.Data;
using CopaFilmes.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Xunit;
using System.Linq;

namespace CopaFilmesTest.Controllers
{
    public class FilmesControllerTest
    {
        [Fact]
        public void SortFilmesTest()
        {
            var listFilmes = FilmesController.SortFilmes(buildFilmesList()).ToList();
            // battles
            Assert.Equal("Deadpool 2", listFilmes[0].titulo);
            Assert.Equal("Vingadores: Guerra Infinita", listFilmes[1].titulo);

            Assert.Equal("Han Solo: Uma História Star Wars", listFilmes[2].titulo);
            Assert.Equal("Thor: Ragnarok", listFilmes[3].titulo);

            Assert.Equal("Hereditário", listFilmes[4].titulo);
            Assert.Equal("Os Incríveis 2", listFilmes[5].titulo);

            Assert.Equal("Jurassic World: Reino Ameaçado", listFilmes[6].titulo);
            Assert.Equal("Oito Mulheres e um Segredo", listFilmes[7].titulo);
        }

        [Fact]
        public void ExecuteChallangesTest()
        {
            var sortedFilmes = FilmesController.SortFilmes(buildFilmesList());
            var resultChallanges = FilmesController.ExecuteChallanges(sortedFilmes);
            // first level
            Assert.Equal("Vingadores: Guerra Infinita", resultChallanges.ToList()[0].titulo);
            Assert.Equal("Thor: Ragnarok", resultChallanges.ToList()[1].titulo);
            Assert.Equal("Os Incríveis 2", resultChallanges.ToList()[2].titulo);
            Assert.Equal("Jurassic World: Reino Ameaçado", resultChallanges.ToList()[3].titulo);

            // final level
            resultChallanges = FilmesController.ExecuteChallanges(resultChallanges);            
            Assert.Equal("Vingadores: Guerra Infinita", resultChallanges.ToList()[0].titulo);
            Assert.Equal("Os Incríveis 2", resultChallanges.ToList()[1].titulo);
        }   

        private IEnumerable<Filme> buildFilmesList()
        {
            List<Filme> listFilmes = new List<Filme>();
            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Os Incríveis 2",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt4881806",
                titulo = "Jurassic World: Reino Ameaçado",
                anoLancamento = 0,
                nota = 6.7
            });

            listFilmes.Add(new Filme
            {
                id = "tt5164214",
                titulo = "Oito Mulheres e um Segredo",
                anoLancamento = 0,
                nota = 6.3
            });

            listFilmes.Add(new Filme
            {
                id = "tt7784604",
                titulo = "Hereditário",
                anoLancamento = 0,
                nota = 7.8
            });

            listFilmes.Add(new Filme
            {
                id = "tt4154756",
                titulo = "Vingadores: Guerra Infinita",
                anoLancamento = 0,
                nota = 8.8
            });

            listFilmes.Add(new Filme
            {
                id = "tt5463162",
                titulo = "Deadpool 2",
                anoLancamento = 0,
                nota = 8.1
            });

            listFilmes.Add(new Filme
            {
                id = "tt3778644",
                titulo = "Han Solo: Uma História Star Wars",
                anoLancamento = 0,
                nota = 7.2
            });

            listFilmes.Add(new Filme
            {
                id = "tt3501632",
                titulo = "Thor: Ragnarok",
                anoLancamento = 0,
                nota = 7.9
            });

            return listFilmes;
        }
    }
}
