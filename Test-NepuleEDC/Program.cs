using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Test_NepuleEDC
{
    class Program
    {
        // Create a reference to our browser
        IWebDriver driver = new ChromeDriver();
       

        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://test.nepule.net/#/signin");

            //IWebElement email_element = driver.FindElement(By.Name("email"));
            //email_element.SendKeys("daniel.aroka@gmail.com");

            //IWebElement passW_element = driver.FindElement(By.Name("password"));
            //passW_element.SendKeys("DJgPUcEqdrXHGaU4$");

            //IWebElement button_element = driver.FindElement(By.XPath("//button"));
            //System.Threading.Thread.Sleep(2000);
            //button_element.Click();
            //string url = driver.Url;
            //Console.Read();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Nepule webbapplication
            driver.Navigate().GoToUrl("https://test.nepule.net");
            //LogIn();
        }

        //Execute log in test
        [Test]
        public void ExecuteLoggInTest()
        {

            try
            {
                //Find Elements and perform operation
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
                driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                System.Threading.Thread.Sleep(2000);
 
                var url = driver.Url;          // Getting the current url
                Console.WriteLine(url);
                driver.Navigate().GoToUrl('"'+url + '"');  // Navigating to the current url
            }
            catch (Exception e)
            {
               
                Console.Write(e);
            }
            Console.Read();
           
           // Assert.AreEqual("https://test.nepule.net/#/dashboard", url);
           Assert.True(driver.Title.Contains("Dashboard"));
           Console.Write("Navigated to correct webpage");

       }

        // Test whether the menu is collapsed or expanded but clicking the button
        [Test]
        public void ClickMenuButtonToCollapseOrExpand()
        {
            try
            {
                //Find Elements and perform operation
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
                driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
                System.Threading.Thread.Sleep(2000);
                
                for (int i = 0; i < 6; i++) // Click the expand/collape button 6 times to test
                {
                    driver.FindElement(By.XPath("//*[@class='fa fa-reorder']")).Click();        
                    Console.WriteLine("Expanded and collapsed");
                }
              
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            Console.Read();
        }

        [Test]
        public void ClickEmailToResetPassword()
        {

            try
            {
                //Find Elements and perform operation
               // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
                driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
                //LogIn();
                // driver.FindElement(By.XPath("//button" + Keys.Enter));
                System.Threading.Thread.Sleep(2000);

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                var url = driver.Url;          // Getting the current url
                driver.Navigate().GoToUrl('"' + url + '"');  // Navigating to the current url

                driver.FindElement(By.XPath("//*[@href='/#/mysettings']")).Click();
                var np = "Obidha70";
                driver.FindElement(By.XPath("//*[@ng-model='passwordModel.oldPassword']")).SendKeys("DJgPUcEqdrXHGaU4$"); // Current password
                driver.FindElement(By.XPath("//*[@ng-model='passwordModel.newPassword']")).SendKeys(np); // New password
                driver.FindElement(By.XPath("//*[@ng-model='passwordModel.confirmPassword']")).SendKeys(np + Keys.Enter); // Confirm password
                                                                                                                          // driver.FindElement(By.XPath("//*[@localize data-localize='Change password']")).Click();

                driver.FindElement(By.XPath("//*[@class='fa fa-sign-out']")).Click();
                driver.FindElement(By.XPath("//*[@id='bot2-Msg1']")).Click();

               
                // Log in på nytt för att testa nya lösenordet
                driver.Navigate().GoToUrl("https://test.nepule.net");
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.FindElement(By.XPath("//*[@ng-model='username']")).SendKeys("daniel.aroka@gmail.com");
                driver.FindElement(By.XPath("//*[@ng-model='password']")).SendKeys(np + Keys.Enter);
                  
                   
                Assert.True(driver.Title.Contains("Dashboad"));
                Console.WriteLine("Successfull login");

                Console.WriteLine(np);
            }
            catch (Exception e)
            {

                Console.Write(e);
            }

            Console.Read();
           
        }

        [Test]
        public void ClickSubjectAndSeeSubjectOnTheStudy()
        {
            try
            {
                //Find Elements and perform operation
             
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
                driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
                System.Threading.Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@data-localize='Subjects']")).Click();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));


            }
            catch (Exception e)
            {
                Console.Write(e);
            }
         
            
           Assert.True(driver.Title.Contains("Subjects"));
           Console.Write("The subjects on study are seen when Subject is clicked");
           Console.ReadLine();
        }

        //public void LogIn()
        //{
        //    driver.Navigate().GoToUrl("https://test.nepule.net");
        //    driver.FindElement(By.XPath("//*[@type='email']")).SendKeys("daniel.aroka@gmail.com");
        //    driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("DJgPUcEqdrXHGaU4$" + Keys.Enter);
        //    System.Threading.Thread.Sleep(2000);
                     
        //}

        // Close the driver
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}
