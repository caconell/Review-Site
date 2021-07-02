using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewControllerTests
    {

        ReviewController sut;
        IRepository<Review> reviewRepo;
    
        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ReviewController(reviewRepo);

        }

        public static implicit operator ReviewControllerTests(ReviewController v)
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
            var result = sut.Create(2);
            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Is_A_List_Of_Reviews()
        {
            // Arrange
            var expectedReviews = new List<Review>();
            reviewRepo.GetAll().Returns(expectedReviews);

            //Act
            var result = sut.Index();

            //Assert
            Assert.IsType<List<Review>>(result.Model);
        }

        [Fact]
        public void Index_Passes_A_List_Of_Reviews_To_View()
        {
            // Arrange
            var expectedReviews = new List<Review>();
            reviewRepo.GetAll().Returns(expectedReviews);

            //Act
            var result = sut.Index();

            //Assert
            Assert.Equal(expectedReviews, result.Model);
        }
    }
}
