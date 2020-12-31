using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"D:\Drivers\chromedriver_win32_87");
            driver.Url = "http://eaapp.somee.com";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void DemoTest()
        {
            IWebElement lnkLogin = driver.FindElement(By.LinkText("Login"));
            lnkLogin.Click();
            IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            txtUserName.SendKeys("admin");
            IWebElement txtPassword = driver.FindElement(By.Name("Password"));
            txtPassword.SendKeys("password");
            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn.btn-default"));
            btnLogin.Click();
        }
    }
}