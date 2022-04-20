using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelusFramework.Base;
using TelusFramework.Extensions;
using AutoItX3Lib;

namespace TelusTests.Pages
{
    public class RegistrationPage : BasePage
    {
        //[FindsBy(How = How.Id, Using = "firstName")]
        //IWebElement FirstName { get; set; }
        //[FindsBy(How = How.Id, Using = "lastName")]
        //IWebElement LastName { get; set; }

        IWebElement FirstName => DriverContext.Driver.FindElement(By.Id("firstName"));
        IWebElement LastName => DriverContext.Driver.FindElement(By.Id("lastName"));
        IWebElement Email => DriverContext.Driver.FindElement(By.Id("userEmail"));
        IWebElement Male => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        IWebElement Female => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Female')]"));
        IWebElement Other => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Other')]"));
        IWebElement MobileNumber => DriverContext.Driver.FindElement(By.Id("userNumber"));
        IWebElement DateOfBirth => DriverContext.Driver.FindElement(By.Id("dateOfBirthInput"));
        IWebElement UserSubjects => DriverContext.Driver.FindElement(By.XPath("//div[@id='subjectsWrapper']/div[2]/div/div/div[2]"));
        IWebElement YearClick => DriverContext.Driver.FindElement(By.XPath("//*[@class='react-datepicker']/div[2]/div[1]/div[2]/div[2]"));
        IWebElement Hobby1 => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
        IWebElement Hobby2 => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Reading')]"));
        IWebElement Hobby3 => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Music')]"));
        IWebElement UploadImage => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Select picture')]"));
        IWebElement UserAddress => DriverContext.Driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));

        IWebElement StateAndCity => DriverContext.Driver.FindElement(By.XPath("//div[contains(text(),'Select State')]"));
        IWebElement State => DriverContext.Driver.FindElement(By.XPath("//div[contains(text(),'Select State')]"));
        IWebElement SelectState => DriverContext.Driver.FindElement(By.XPath("//div[contains(text(),'Rajasthan')]"));
        IWebElement City => DriverContext.Driver.FindElement(By.XPath("//div[contains(text(),'Select City')]"));
        IWebElement SubmitButton => DriverContext.Driver.FindElement(By.Id("submit"));



        //div[contains(text(),'Rajasthan')]
        //label[@id='stateCity-label']
        //IList<IWebElement> Year => DriverContext.Driver.FindElements(By.XPath("//*[@class='react-datepicker']/div[2]/div[1]/div[2]/div[2]/select"));
        //IList<IWebElement> Date => DriverContext.Driver.FindElements(By.XPath("//*[@class='react-datepicker__month']/div[1]/div"));


        public void UserName(string firstname, string lastName)
        {
            FirstName.Click();
            FirstName.SendKeys(firstname);
            LastName.Click();
            LastName.SendKeys(lastName);
        }

        public void UserEmail(string email)
        {
            Email.Click();
            Email.SendKeys(email);
        }

        public void UserGender(string gender)
        {
            if (gender == "Male")
            {
                Male.Click();
            }
            else if (gender == "Female")
            {
                Female.Click();
            }
            else if (gender == "Other")
            {
                Other.Click();
            }
        }

        public void UserPhone(string mobile)
        {
            MobileNumber.Click();
            MobileNumber.SendKeys(mobile);
        }
        public void UserDOB()
        {
            DateOfBirth.Click();
            DateOfBirth.SendKeys(Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace);
            DateOfBirth.SendKeys("2002");
        }       

        public void Subjects(string subjects)
        {   
            string s = subjects;
            string[] values = s.Split(',');
            string Subject1 = values[0];
            string Subject2 = values[1];
           
            ScrollToElement(UserSubjects);
            MobileNumber.Click();

            Actions actions = new Actions(DriverContext.Driver);            
            actions.DoubleClick(UserSubjects).SendKeys(Subject1).SendKeys(Keys.Enter).SendKeys(Subject2).SendKeys(Keys.Enter).Build().Perform();
                 

        }
        public void UserHobby(string hobby)
        {
            if (hobby == "Sports")
            {
                Hobby1.Click();
            }
            else if (hobby == "Reading")
            {
                Hobby2.Click();
            }
            else if (hobby == "Music")
            {
                Hobby3.Click();
            }
            else if (hobby=="Sports"&&hobby=="Reading")
            {
                Hobby1.Click();
                Hobby2.Click();
            }
            else if (hobby == "Sports" && hobby == "Music")
            {
                Hobby1.Click();
                Hobby3.Click();
            }
            else if (hobby == "Music" && hobby == "Reading")
            {
                Hobby3.Click();
                Hobby2.Click();
            }
        }

        public void ImageUpload()
        {
            UploadImage.Click();
            AutoItX3 autoIT = new AutoItX3();
            autoIT.WinActivate("Open");
            Thread.Sleep(3000);
            autoIT.Send(@"C:\Users\Dell\download.jfif");
            autoIT.Send("{Enter}");
            
            //UploadImage.SendKeys(@"C:\Users\Dell\download.jfif");
        }

        public void CurrentAddress(string Address)
        {
            ScrollToElement(UserAddress);
            UserAddress.Click();
            UserAddress.SendKeys(Address);

            //UploadImage.SendKeys(@"C:\Users\Dell\download.jfif");
        }
        public void SelectStateAndCity()
        {
            ScrollToElement(SubmitButton);
            State.Click();
            SelectState.Click();
            City.Click();
            

            //UploadImage.SendKeys(@"C:\Users\Dell\download.jfif");
        }

        public void SubmitForm()
        {
            SubmitButton.Click();


            //UploadImage.SendKeys(@"C:\Users\Dell\download.jfif");
        }

        internal void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(
             "arguments[0].scrollIntoView();", element);
        }

       

    }
}
