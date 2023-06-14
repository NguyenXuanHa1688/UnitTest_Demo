using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Demo.Controllers;
using UnitTest_Demo.Data.Interface;
using UnitTest_Demo.Model;
using UnitTest_Demo.VeryBasic;

namespace MSTest.Controller_Test
{
    [TestClass]
    public class MangaController_Test
    {
        private Mock<IManga> _mangaService;
        private Fixture _fixture;
        private MangaController _controller;
        public MangaController_Test()
        {
            _fixture = new Fixture();
            _mangaService = new Mock<IManga>();
            _controller = new MangaController(_mangaService.Object);
        }
        [TestMethod]
        public async Task GetAll_ReturnListOfManga()
        {
            var mangaList = _fixture.CreateMany<Manga>(5).ToList();
            _mangaService.Setup(x => x.GetAll()).Returns(mangaList);
            var result = await _controller.GetAll();
            result.Should().BeOfType<OkObjectResult>();
            var okRequestResult = result as OkObjectResult;
            okRequestResult.Value.Should().Be(mangaList);
        }

        [TestMethod]
        public async Task GetAll_CheckException()
        {
            _mangaService.Setup(x => x.GetAll()).Throws(new Exception());
            var result = await _controller.GetAll();
            result.Should().BeOfType<BadRequestObjectResult>();
        }

        [TestMethod]
        public async Task Post_ValidManga_SaveMangaIntoDatabase()
        {
            Manga newManga = new Manga() { Id = 7, Name = "CONAN", Description = "FOR TEEN", price = 9};
            _mangaService.Setup(x => x.Post(It.IsAny<Manga>())).Returns(newManga);
            var result = await _controller.Post(newManga);
            result.Should().BeOfType<OkObjectResult>();
            var okRequestResult = result as OkObjectResult;
            okRequestResult.Value.Should().Be(newManga);
        }

        [TestMethod]
        public async Task Put_ValidManga_UpdateMangaIntoDatabase()
        {
            Manga newManga = new Manga() { Id = 7, Name = "CONAN", Description = "FOR TEEN", price = 9 };
            _mangaService.Setup(x => x.Post(It.IsAny<Manga>())).Returns(newManga);
            var result = await _controller.Post(newManga);
            result.Should().BeOfType<OkObjectResult>();
            var okRequestResult = result as OkObjectResult;
            okRequestResult.Value.Should().Be(newManga);
        }

        [TestMethod]
        public async Task Delete_ValidManga_DeleteMangaFromDatabase()
        {
            List<Manga> newManga = new List<Manga>() 
            {
                new Manga() { Id = 1, Name = "CONAN", Description = "FOR TEEN", price = 5 },
                new Manga() { Id = 2, Name = "CONAN-1", Description = "FOR TEEN", price = 6 },
                new Manga() { Id = 3, Name = "CONAN-2", Description = "FOR TEEN", price = 7 }
            };
            _mangaService.Setup(x => x.Delete(2)).Returns(newManga);
            var result = await _controller.Delete(2);
            result.Should().BeOfType<OkObjectResult>();
            var okRequestResult = result as OkObjectResult;
            okRequestResult.Value.Should().Be(newManga);
        }

    }
}
