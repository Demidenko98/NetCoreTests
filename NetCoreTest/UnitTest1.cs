using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NetCoreTest
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [OneTimeSetUp]
        public void Setup()
        {
            driver.Url = "https://www.google.com.ua/?hl=ru";
        }

        [Test]
        public void Add()
        {
            int expected = 4;
            Assert.AreEqual(expected, 4);
        }


        [Test]
        public void Minus()
        {
            int expected = 0;
            Assert.AreEqual(expected, 0);
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}