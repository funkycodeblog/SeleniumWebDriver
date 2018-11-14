using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            // Create an instance of the driver
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:/google.com");

            var input = driver.FindElement(By.Id("lst-ib"));
            input.SendKeys("calculator");
            input.SendKeys(Keys.Enter);
      

        }
    }
}
