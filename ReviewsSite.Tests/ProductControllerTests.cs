using System;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ProductControllerTests

    {
    
            [Fact]
            public void Index_Returns_A_View()
            {
                var underTest = new ProductController();

                var result = underTest.Index();

                Assert.IsType<ViewResult>(result);
            }
        }

}
