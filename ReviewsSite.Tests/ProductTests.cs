using System;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ProductTests
    {

        Product sut;

        public ProductTests()
        {

        }

        [Fact]
        public void Product_Constructor_Set_Id_On_Product()
        {
            // Arrange

            // Act
            sut = new Product(420);

            // Assert
            Assert.Equal(420, sut.Id);
        }
    }
}



// Arrange
// Act
// Assert