using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NepuleEDC
{
    //public enum IdBy { Id, Name, Link, LinkText, Xpath, ClassName, TagName }
    //class SelServ
    //{

    //    public static IWebDriver driver { get; set; }

    //    public static IWebElement locateElement(string element, IdBy type, int retry = 0)
    //    {
    //        try
    //        {
    //            return returnElement(element, type);
    //        }
    //        catch (Exception e)
    //        {
    //            retry++;
    //            if (retry > 5)
    //                throw new ElementNotVisibleException(e.Message);
    //            Thread.Sleep(2000);
    //            return locateElement(element, type, retry);
    //        }

    //    }
    //    //Andra
    //    //public static IWebElement locateElement(string element, IdBy type, int retry = 0)
    //    //{
    //    //    try
    //    //    {
    //    //        switch (type)
    //    //        {
    //    //            case IdBy.Id:
    //    //                return driver.FindElement(OpenQA.Selenium.By.Id(element));

    //    //            case IdBy.Name:
    //    //                return driver.FindElement(OpenQA.Selenium.By.Name(element));

    //    //            case IdBy.Link:
    //    //                return driver.FindElement(OpenQA.Selenium.By.PartialLinkText(element));

    //    //            case IdBy.LinkText:
    //    //                return driver.FindElement(OpenQA.Selenium.By.LinkText(element));

    //    //            case IdBy.Xpath:
    //    //                return driver.FindElement(OpenQA.Selenium.By.XPath(element));

    //    //            case IdBy.ClassName:
    //    //                return driver.FindElement(OpenQA.Selenium.By.ClassName(element));

    //    //            default:
    //    //                return null;
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        retry++;
    //    //        if (retry > 5) throw new ElementNotVisibleException(ex.Message);
    //    //        Thread.Sleep(2000);
    //    //        return locateElement(element, type, retry);
    //    //    }


    //    //}

    //    public static IWebElement returnElement(string element, IdBy type)
    //    {
    //        switch (type)
    //        {
    //            case IdBy.Id:
    //                return driver.FindElement(By.Id(element));
    //            case IdBy.Name:
    //                return driver.FindElement(By.Name(element));
    //            case IdBy.Link:
    //                return driver.FindElement(By.PartialLinkText(element));
    //            case IdBy.LinkText:
    //                return driver.FindElement(By.LinkText(element));
    //            case IdBy.Xpath:
    //                return driver.FindElement(By.XPath(element));
    //            case IdBy.ClassName:
    //                return driver.FindElement(By.ClassName(element));
    //            case IdBy.TagName:
    //                return driver.FindElement(By.TagName(element));
    //            default:
    //                return null;
    //        }

    //        //Andra
    //        //     public static IWebElement findElement(string element, IdBy type)
    //        //{

    //        //    switch (type)
    //        //    {
    //        //        case IdBy.Id:
    //        //            return driver.FindElement(By.Id(element));

    //        //        case IdBy.Name:
    //        //            return driver.FindElement(By.Name(element));

    //        //        case IdBy.Link:
    //        //            return driver.FindElement(By.PartialLinkText(element));

    //        //        case IdBy.LinkText:
    //        //            return driver.FindElement(By.LinkText(element));

    //        //        case IdBy.Xpath:
    //        //            return driver.FindElement(By.XPath(element));

    //        //        case IdBy.ClassName:
    //        //            return driver.FindElement(By.ClassName(element));

    //        //        case IdBy.TagName:
    //        //            return driver.FindElement(By.TagName(element));

    //        //        default:
    //        //            return null;
    //        //    }
    //    }
    //}
}
