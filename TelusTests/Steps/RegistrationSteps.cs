using TelusFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TelusFramework.Base;
using TelusFramework.Config;
using TelusTests.Pages;

namespace TelusTests.Steps
{
    [Binding]
    public class RegistrationSteps : BaseStep
    {

        [Given(@"User Navigated to the Registration Page")]
        public void GivenUserNavigatedToTheRegistrationPage()
        {
            NavigateSite();
            CurrentPage = GetInstance<RegistrationPage>();
        }

        [Given(@"User entered the name (.*) and (.*)")]
        public void GivenUserEnteredTheNameAnd(string FirstName, string LastName)
        {
            CurrentPage.As<RegistrationPage>().UserName(FirstName, LastName);
        }

        [Given(@"User entered the email address (.*)")]
        public void GivenUserEnteredTheEmailAddress(string Email)
        {
            CurrentPage.As<RegistrationPage>().UserEmail(Email);
        }

        [Given(@"User select the gender (.*)")]
        public void GivenUserSelectTheGender(string Gender)
        {
            CurrentPage.As<RegistrationPage>().UserGender(Gender);
        }

        [Given(@"User entered the mobile number (.*)")]
        public void GivenUserEnteredTheMobileNumber(string Mobile)
        {
            CurrentPage.As<RegistrationPage>().UserPhone(Mobile);
        }

        [Given(@"User typed the date of birth")]
        public void GivenUserTypedTheDateOfBirth()
        {
            CurrentPage.As<RegistrationPage>().UserDOB();
        }      

        [Given(@"User entered the  (.*)")]
        public void GivenUserEnteredThe(string Subjects)
        {
            CurrentPage.As<RegistrationPage>().Subjects(Subjects);
        }

        [Given(@"User selected the (.*)")]
        public void GivenUserSelectedThe(string Hobby)
        {
            CurrentPage.As<RegistrationPage>().UserHobby(Hobby) ;
        }

        [Given(@"User upload the picture")]
        public void GivenUserUploadThePicture()
        {
            CurrentPage.As<RegistrationPage>().ImageUpload();
        }

        [Given(@"User provide the (.*)")]
        public void GivenUserProvideThe(string Address)
        {
            CurrentPage.As<RegistrationPage>().CurrentAddress(Address);
        }      

        [Given(@"User entered the state and city")]
        public void GivenUserEnteredTheStateAndCity()
        {
            CurrentPage.As<RegistrationPage>().SelectStateAndCity();
        }

        [When(@"User Click the Submit button")]
        public void WhenUserClickTheSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }



        [Then(@"registration is complete")]
        public void ThenRegistrationIsComplete()
        {
            ScenarioContext.Current.Pending();
        }






















        //[Given(@"User Navigated to the Registration Page")]
        //public void GivenUserNavigatedToTheRegistrationPage()
        //{
        //    NavigateSite();
        //    CurrentPage = GetInstance<RegistrationPage>();

        //}

        //[Given(@"User enetered (.*) and (.*)")]
        //public void GivenUserEneteredAnd(string FirstName, string LastName)
        //{
        //    CurrentPage.As<RegistrationPage>().UserName(FirstName, LastName);
        //}

        //[Given(@"User enetered (.*)")]
        //public void GivenUserEnetered(string Email)
        //{
        //    CurrentPage.As<RegistrationPage>().UserEmail(Email);
        //}

        //[Given(@"User selected (.*)")]
        //public void GivenUserSelected(string Gender)
        //{
        //    CurrentPage.As<RegistrationPage>().UserEmail(Gender);
        //}

        //[Given(@"User entered (.*)")]
        //public void GivenUserEntered(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Given(@"User entered the (.*)")]
        //public void GivenUserEnteredThe(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Given(@"User selected the (.*)")]
        //public void GivenUserSelectedThe(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Given(@"User upload the picture")]
        //public void GivenUserUploadThePicture()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"User entered the address")]
        //public void WhenUserEnteredTheAddress()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"registration is complete")]
        //public void ThenRegistrationIsComplete()
        //{
        //    ScenarioContext.Current.Pending();
        //}

    }
}
