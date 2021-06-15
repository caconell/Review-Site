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
        public void Product_Constructor_Sets_Id_On_Product()
        {
            // Arrange

            // Act
            sut = new Product(199, "", "");

            // Assert
            Assert.Equal(199, sut.Id);
        }

        [Fact]
        public void Product_Constructor_Sets_Name_On_Product()
        {
            // Arrange

            // Act
            sut = new Product(402, "Moist Cheetos", "");

            // Assert
            Assert.Equal("Moist Cheetos", sut.Name);
        }

        [Fact]
        public void Product_Constructor_Sets_Image_On_Product()
        {
            // Arrange

            // Act
            sut = new Product(68, "Moist Cheetos", "testpic.png");

            // Assert
            Assert.Equal("testpic.png", sut.Image);
        }

        [Fact]
        public void SetDescription_Sets_Description_On_Product()
        {
            // Arrange
            sut = new Product(68, "Moist Cheetos", "testpic.png");

            // Act
            sut.SetDescription("This product is state-of-the-art and really, really awesome. Buy it now and make your life so much easier.");

            // Assert
            Assert.Equal("This product is state-of-the-art and really, really awesome. Buy it now and make your life so much easier.", sut.Description);
        }

    }
}



// Arrange
// Act
// Assert