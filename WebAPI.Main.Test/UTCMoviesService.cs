using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Helper;
using WebAPI.Entities;

namespace WebAPI.Main.Test
{
    [TestClass]
    public class UTCMoviesService
    {
        private IMoviesService moviesService;
        private IEnumerable<Entities.Movies> expectedMoviesList;
        private string location = string.Empty;
        private string language = string.Empty;

        [TestMethod]
        public void TestRetrieveAllMovies()
        {
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveAllMovies - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies();
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveAllMovies - ExpectedMoviesList is null");
            Assert.AreEqual(10, expectedMoviesList.Count(), "Movies count doesn't match");
        }

        [TestMethod]
        public void TestRetrieveMoviesByEurope()
        {
            location = "Europe";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByEurope - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByEurope - ExpectedMoviesList is null");
            Assert.AreEqual(4, expectedMoviesList.Count(), $"Movies count doesn't match for the location-{location}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByAsia()
        {
            location = "Asia";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByAsia - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByAsia - ExpectedMoviesList is null");
            Assert.AreEqual(4, expectedMoviesList.Count(), $"Movies count doesn't match for the location-{location}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByNorthAmerica()
        {
            location = "NorthAmerica";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByNorthAmerica - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByNorthAmerica - ExpectedMoviesList is null");
            Assert.AreEqual(2, expectedMoviesList.Count(), $"Movies count doesn't match for the location-{location}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByEnglish()
        {
            language = "English";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByEnglish - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByEnglish - ExpectedMoviesList is null");
            Assert.AreEqual(4, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesBySpanish()
        {
            language = "Spanish";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesBySpanish - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesBySpanish - ExpectedMoviesList is null");
            Assert.AreEqual(2, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByTamil()
        {
            language = "Tamil";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByTamil - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByTamil - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByHindi()
        {
            language = "Hindi";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByHindi - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByHindi - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByJapanese()
        {
            language = "Japanese";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByJapanese - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByJapanese - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByChinese()
        {
            language = "Chinese";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByChinese - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByChinese - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for the language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByEuropeEnglish()
        {
            location = "Europe";
            language = "English";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByEuropeEnglish - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location, language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByEuropeEnglish - ExpectedMoviesList is null");
            Assert.AreEqual(3, expectedMoviesList.Count(), $"Movies count doesn't match for location-{location} and language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByNorthAmericaEnglish()
        {
            location = "NorthAmerica";
            language = "English";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByNorthAmericaEnglish - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location, language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByNorthAmericaEnglish - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for location-{location} and language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByAsiaTamil()
        {
            location = "Asia";
            language = "Tamil";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByIndiaTamil - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location, language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByIndiaTamil - ExpectedMoviesList is null");
            Assert.AreEqual(1, expectedMoviesList.Count(), $"Movies count doesn't match for location-{location} and language-{language}");
        }

        [TestMethod]
        public void TestRetrieveMoviesByEuropeTamil()
        {
            location = "Europe";
            language = "Tamil";
            moviesService = new MoviesService();
            Assert.IsNotNull(moviesService, "TestRetrieveMoviesByEuropeTamil - MoviesService is null");

            expectedMoviesList = moviesService.GetMovies(location: location, language: language);
            Assert.IsNotNull(expectedMoviesList, "TestRetrieveMoviesByEuropeTamil - ExpectedMoviesList is null");
            Assert.AreEqual(0, expectedMoviesList.Count(), $"Movies count doesn't match for location-{location} and language-{language}");
        }
    }
}
