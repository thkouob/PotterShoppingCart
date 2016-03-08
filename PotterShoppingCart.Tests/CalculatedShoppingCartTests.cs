using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CalculatedShoppingCartTests
    {
        [TestMethod()]
        public void Test_1Book1()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            
            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and1Book2()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 1);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and1Book2and1Book3()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 1);
            target.AddBook("book3", 1);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and1Book2and1Book3and1Book4()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 1);
            target.AddBook("book3", 1);
            target.AddBook("book4", 1);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and1Book2and1Book3and1Book4and1Book5()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 1);
            target.AddBook("book3", 1);
            target.AddBook("book4", 1);
            target.AddBook("book5", 1);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and1Book2and2Book3()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 1);
            target.AddBook("book3", 2);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_1Book1and2Book2and2Book3()
        {
            //arrange
            CalculatedShoppingCart target = new CalculatedShoppingCart();
            target.AddBook("book1", 1);
            target.AddBook("book2", 2);
            target.AddBook("book3", 2);

            //act
            var actual = target.CalculateTotalPrice();
            //Assert

            var expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}
