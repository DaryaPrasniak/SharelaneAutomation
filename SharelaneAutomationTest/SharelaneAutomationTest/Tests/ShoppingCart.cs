using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Tests
{
    internal class ShoppingCart : BaseTest
    {
        [Test]
        public void Test1()
        {
            string email = "amit_wang@955.33.sharelane.com";
            string password = "1111";
            string quantityInput = "52";

            LoginPage.Login(email, password);
            ShoppingCartPage.ClickBookLink();
            SearchPage.ClickAddToCartButton();
            ShoppingCartPage.ClickShoppingCartLink();
            ShoppingCartPage.ClearQuantityField();
            ShoppingCartPage.SetBookQuantity(quantityInput);
            ShoppingCartPage.ClickUpdateButton();
         
            
            Assert.AreEqual(ShoppingCartPage.DiscountPercentage(), "3");

            ShoppingCartPage.ClickProceedToCheckoutButton();
        }
    }
}
