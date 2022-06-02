using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Integration_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _webDriver.Url = "https://localhost:5001/";
            _webDriver.Navigate();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var textarea = _webDriver.FindElement(By.Id("textarea"));
            textarea.Click();
            textarea.SendKeys("Hello\nHow are you?");
        }

        [TestCleanup]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
