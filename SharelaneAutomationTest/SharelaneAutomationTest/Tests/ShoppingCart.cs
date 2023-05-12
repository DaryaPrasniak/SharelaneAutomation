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
            string email = "marina_wang@252.86.sharelane.com";
            string password = "1111";
            string quantityInput = "52";

            LoginPage.Login(email, password);
            ShoppingCartPage.ClickBookLink();
            SearchPage.ClickAddToCartButton();
            ShoppingCartPage.ClickShoppingCartLink();
            ShoppingCartPage.ClearQuantityField();
            ShoppingCartPage.SetBookQuantity(quantityInput);
            ShoppingCartPage.ClickUpdateButton();
         
            var discountPercentage = ChromeDriver.FindElement(By.XPath("//table/tbody/tr[2]/td[5]/p/b")).Text;
            Assert.AreEqual(discountPercentage, "3");

            ShoppingCartPage.ClickProceedToCheckoutButton();
        }
    }
}
