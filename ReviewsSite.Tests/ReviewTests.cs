using System;
using ReviewsSite.Models;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {

        Review sut;

        public ReviewTests()
        {

        }

        [Fact]
        public void Review_Constructor_Sets_Id_On_Review()
        {
            // Arrange

            // Act
            sut = new Review(99, 1, "John Doe", "Amazing tacos");

            // Assert
            Assert.Equal(99, sut.Id);
        }

        [Fact]
        public void Review_Constructor_Sets_ProductId_On_Review()
        {
            // Arrange

            // Act
            sut = new Review(99, 1, "John Doe", "Amazing tacos");

            // Assert
            Assert.Equal(1, sut.ProductId);
        }

        [Fact]
        public void Reviewer_Constructor_Sets_Reviewername_On_Review()
        {
            // Arrange

            // Act
            sut = new Review(99, 1, "John Doe", "Amazing tacos");

            // Assert
            Assert.Equal("John Doe", sut.Reviewername);
        }

        [Fact]
        public void Review_Constructor_Sets_Content_On_Review()
        {
            // Arrange

            // Act
            sut = new Review(99, 1, "John Doe", "Amazing tacos");

            // Assert
            Assert.Equal("Amazing tacos", sut.Content);
        }

    }
}
