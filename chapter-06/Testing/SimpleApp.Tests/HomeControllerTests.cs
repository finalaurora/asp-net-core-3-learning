using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        class FakeDataSource : IDataSource
        {
            public FakeDataSource(Product[] data) => Products = data;
            public IEnumerable<Product> Products {get; set;}
        }

        [Fact]
        public void IndexActionModelIsComplete(){

            // Arrange
            var controller = new HomeController();

            Product[] testData = new Product[]{
                new Product{Name = "P1", Price= 324M},
                new Product{Name = "P2", Price = 48.95M},
                new Product{Name = "P3", Price = 100M}
            };

            FakeDataSource data = new FakeDataSource(testData);
            controller.dataSource=data;
            //Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

            //  Assert
            Assert.Equal(data.Products, model, Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
    }
}