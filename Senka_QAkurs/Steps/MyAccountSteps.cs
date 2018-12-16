using NUnit.Framework;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.SignIn);

        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);
            
        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);
        }
        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            ut.ClickOnElement(ma.wishlist); 
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage wl = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplay(wl.WishListForm), "Form is not present");
        }
        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.email, email);
            ut.ClickOnElement(ap.createAcc);
        }



        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.custfirstname, TestConstants.FirstName);
            ut.EnterTextInElement(sup.custlastname, TestConstants.LastName);
            string FullName = TestConstants.FirstName + " " + TestConstants.LastName;
            ScenarioContext.Current.Add(TestConstants.FullName, FullName);
            ut.EnterTextInElement(sup.pass, TestConstants.Password);
            ut.EnterTextInElement(sup.firstname, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastname, TestConstants.LastName);
            ut.EnterTextInElement(sup.address, TestConstants.Address);
            ut.EnterTextInElement(sup.city, TestConstants.City);
            ut.DropdownSelect(sup.state, TestConstants.State);
            ut.EnterTextInElement(sup.zipcode, TestConstants.ZipCode);
            ut.EnterTextInElement(sup.phone, TestConstants.MobilePhone);
            ut.EnterTextInElement(sup.alias, TestConstants.AdressAlias);
            
            
        }



        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }








        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            Assert.True(ut.ElementDisplay(ma.logOut), "User is not logged in");
        }

        [Given(@"user's full name is displayed")]
        public void GivenUserSFullNameIsDisplayed()
        {
            Utilities ut = new Utilities(Driver);
            string FullName = ScenarioContext.Current.Get<string>(TestConstants.FullName);
            Assert.True(ut.TextPresentInElement(FullName).Displayed, "User's full name is not displayed");

        }

    }
}
