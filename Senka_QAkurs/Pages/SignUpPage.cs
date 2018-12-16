using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class SignUpPage
    {
       
            readonly IWebDriver driver;

            public By custfirstname = By.Id("customer_firstname");
            public By custlastname = By.Id("customer_lastname");
            public By pass = By.Id("passwd");
            public By firstname = By.Id("firstname");
            public By lastname = By.Id("lastname");
            public By address = By.Id("address1");
            public By city = By.Id("city");
            public By state = By.Id("id_state");
            public By zipcode = By.Id("postcode");
            public By country = By.Id("id_country");
            public By phone = By.Id("phone_mobile");
            public By alias = By.Id("alias");
            public By registerBtn = By.Id("submitAccount");


            public SignUpPage(IWebDriver driver)
        { 
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
        }

    }
}
