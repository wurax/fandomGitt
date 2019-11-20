using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBlayerrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.Threading.Tasks;
using Moq;

namespace Fandom.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void productNameTest()
        {
            //Arrange
            string expected = "monster";
            var a = new Product();
            a.productName = "monster";
            //Act

            //Assert
            string actual = a.productName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void productServicesTest()
        {
            //Arrange
            Mock<IProductDB> mockProductDB = new Mock<IProductDB>();

            Product product = new Product();

            product.productName = "monster";
            product.productID = 1;
            product.productDescription = "it works";
            product.quantity = 200;
            product.price = 18.99;
            product.Stocks = new System.Data.Linq.EntitySet<Stock>();
            product.Locations = new System.Data.Linq.EntitySet<Location>();
            product.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
            product.ProdPropertyValues = new System.Data.Linq.EntitySet<ProdPropertyValue>();
            product.ProductFandoms = new System.Data.Linq.EntitySet<ProductFandom>();
            product.Supplier = new Supplier();


            mockProductDB.Setup(obj => obj.getProductByID(1)).Returns(product);

            //Act
            IProductService productService = new ProductServices(mockProductDB.Object);
            ProductData data = productService.GetProductName(1);
            //assert

            //Assert.IsNotNull(data);
           
           Assert.IsTrue(data.productName == "monster");
           Assert.IsTrue(data.productID == 1);
           Assert.IsTrue(data.productDescription == "it works");
           Assert.IsTrue(data.quantity == 200);
           Assert.IsTrue(data.price == 18.99);
           Assert.IsTrue(data.supplierID == 0);
        }
    }
}