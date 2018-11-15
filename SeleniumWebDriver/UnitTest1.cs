using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class UnitTest1
    {

        static Dictionary<string, int> keyIds = new Dictionary<string, int>
           {{"1", 33}   ,
    {"2",34},
    {"3",35},
    {"4",23},
    {"5",24},
    {"6",25},
    {"7",13},
    {"8",14},
    {"9",15},
    {"0",43},
    {"+",46},
    {"-",36},
    {"*",26},
    {"/",16},
    {"=",45}};

        [Test]
        public void Calculator_Should_Return_9_For_4_Plus_5()
        {
            int expected = 9;
           
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:/google.com");

            var input = driver.FindElement(By.Id("lst-ib"));
            input.SendKeys("calculator");
            input.SendKeys(Keys.Enter);

            var key4 = driver.FindElement(By.Id("cwbt23"));
            var key5 = driver.FindElement(By.Id("cwbt24"));
            var keyPlus = driver.FindElement(By.Id("cwbt46"));
            var keyEquals = driver.FindElement(By.Id("cwbt45"));
           
            key4.Click();
            keyPlus.Click();
            key5.Click();
            keyEquals.Click();

            var output = driver.FindElement(By.Id("cwos"));
            var result = Convert.ToInt32(output.Text);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
