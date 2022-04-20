using TelusFramework.Base;
using TelusFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TelusFramework.Extensions
{
    public static class WebDriverExtension
    {

        //internal static void WaitForDocumentLoaded(this IWebDriver driver)
        //{
        //    driver.WaitForCondition(drv =>
        //    {
        //        string state = drv.ExecuteJs("return document.readyState").ToString();
        //        return state == "complete";
        //    }, Settings.Timeout);
        //}

        internal static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                };

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        public static IWebElement WaitGetElement(this IWebDriver driver, By by, int timeoutInSeconds, bool checkIsVisible = false)
        {
            IWebElement element;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            try
            {
                if (checkIsVisible)
                {
                    element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                }
                else
                {
                    element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
                }
            }
            catch (NoSuchElementException) { element = null; }
            catch (WebDriverTimeoutException) { element = null; }
            catch (TimeoutException) { element = null; }

            return element;
        }




    }
}
