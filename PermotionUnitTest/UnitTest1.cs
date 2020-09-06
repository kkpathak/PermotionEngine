using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermotionEngineProject;
namespace PermotionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            //Arrange  
         
            List<Product> prodlist = new List<Product>();
            prodlist.Add(new Product("A")
            {
              
                Price=0
            });
            prodlist.Add(new Product("B")
            {
                
                Price = 0
            });
            prodlist.Add(new Product("C")
            {
               
                Price = 0
            });
           
            int expected = 100;
            int actual;
            //Act  

            actual = ProductService.GetTotalPrice(prodlist);
            //Assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {

            //Arrange  

            List<Product> prodlist = new List<Product>();
            prodlist.Add(new Product("A")
            {

                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                
                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                
                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                
                Price = 0
            });

            prodlist.Add(new Product("B")
            {
               
                Price = 0
            });
            prodlist.Add(new Product("B")
            {
               
                Price = 0
            });

            prodlist.Add(new Product("B")
            {
                Price = 0
            });

            prodlist.Add(new Product("B")
            {
                
                Price = 0
            });

            prodlist.Add(new Product("B")
            {
               
                Price = 0
            });
            prodlist.Add(new Product("C")
            {
                // Id = "C",
                Price = 0
            });


            int expected = 370;
            int actual;
            //Act  

            actual = ProductService.GetTotalPrice(prodlist);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {

            //Arrange  

            List<Product> prodlist = new List<Product>();
            prodlist.Add(new Product("A")
            {

                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                //Id = "B",
                Price = 0
            });
            prodlist.Add(new Product("A")
            {
                // Id = "C",
                Price = 0
            });
            
            prodlist.Add(new Product("B")
            {
                
                Price = 0
            });
            prodlist.Add(new Product("B")
            {

                Price = 0
            });

            prodlist.Add(new Product("B")
            {
                Price = 0
            });

            prodlist.Add(new Product("B")
            {

                Price = 0
            });

            prodlist.Add(new Product("B")
            {

                Price = 0
            });
            prodlist.Add(new Product("C")
            {
               
                Price = 0
            });
            prodlist.Add(new Product("D")
            {

                Price = 0
            });


            int expected = 280;
            int actual;
            //Act  

            actual = ProductService.GetTotalPrice(prodlist);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
