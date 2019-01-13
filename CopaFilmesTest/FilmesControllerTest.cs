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
            Assert.Equal("Deadpool 2", listFilmes[0].titulo);
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
                id = "tt3606756",
                titulo = "Jurassic World: Reino Ameaçado",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Oito Mulheres e um Segredo",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Hereditário",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Vingadores: Guerra Infinita",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Deadpool 2",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Han Solo: Uma História Star Wars",
                anoLancamento = 0,
                nota = 8.5
            });

            listFilmes.Add(new Filme
            {
                id = "tt3606756",
                titulo = "Thor: Ragnarok",
                anoLancamento = 0,
                nota = 8.5
            });

            return listFilmes;
        }
    }
}
