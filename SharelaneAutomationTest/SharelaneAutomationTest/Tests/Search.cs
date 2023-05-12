using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Tests
{
    internal class Search : BaseTest
    {
        [Test]
        public void Test1()
        {
            string searchText = "Adventures";

            SearchPage.Search(searchText);

            var addToCartButton = ChromeDriver.FindElement(By.XPath("//table/tbody/tr[5]/td/table[2]"));
            Assert.IsTrue(addToCartButton != null);
        }
    }
}
