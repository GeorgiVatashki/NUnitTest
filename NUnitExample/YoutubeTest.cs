using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace NUnitExample
{
    public class YoutubeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://courses.ultimateqa.com/");
            driver.Manage().Window.Maximize();            
            Assert.IsTrue(driver.Url.Contains("courses"));
            driver.Quit();

        }
    }
}