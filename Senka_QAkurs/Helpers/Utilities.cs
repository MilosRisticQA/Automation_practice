using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
        }

        public void EnterTextInElement(By selector, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);
        }

        public bool ElementDisplay(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Displayed;

        }

        public string GenerateRandomEmail()
        {
            return string.Format("email{0}@mailinator.com", RandomName.Next(100000, 10000000));
        }

        public void DropdownSelect(By select, string option)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(option);
        }

        public IWebElement TextPresentInElement(string text)
        {
            By textElement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement));

        }


    }


   
}

