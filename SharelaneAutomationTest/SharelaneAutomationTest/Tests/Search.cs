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
        
            Assert.IsTrue(SearchPage.AddToCartButton1 != null);
        }
    }
}
