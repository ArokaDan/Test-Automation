using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Test_NepuleEDC
{
    class logIn
    {
        IWebElement email;
        IWebElement password;

       public static void LogIn(IWebElement em, IWebElement pw)
       {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://test.nepule.net");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
            driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
        }
        
    }
}
