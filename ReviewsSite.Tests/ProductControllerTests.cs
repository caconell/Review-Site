using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ProductControllerTests
    {

        ProductController sut;
        IRepository<Product> productRepo;

        public ProductControllerTests()
        {
            productRepo = Substitute.For<IRepository<Product>>();
            sut = new ProductController(productRepo);

        }

        public static implicit operator ProductControllerTests(ProductController v)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Arrange
            var result = sut.Index();

            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            // Arrange
            var result = sut.Details(1);

            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Create_Returns_A_View()
        {
            // Arrange
            var result = sut.Create();
            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Is_A_List_Of_Reviews()
        {
            // Arrange
            var expectedReviews = new List<Product>();
            productRepo.GetAll().Returns(expectedReviews);

            //Act
            var result = sut.Index();

            //Assert
            Assert.IsType<List<Product>>(result.Model);
        }

        [Fact]
        public void Index_Passes_A_List_Of_Reviews_To_View()
        {
            // Arrange
            var expectedReviews = new List<Product>();
            productRepo.GetAll().Returns(expectedReviews);

            //Act
            var result = sut.Index();

            //Assert
            Assert.Equal(expectedReviews, result.Model);
        }
    }
}
