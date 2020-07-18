using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.AutomationPractice
{
    public partial class AutomationPracticePage : BasePage
    {
        public IWebElement signInButton => Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        public IWebElement emailAddressBox => Driver.FindElement(By.CssSelector("#email_create"));
        public IWebElement createAnAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
        public IWebElement emailAddressField => Driver.FindElement(By.Id("email"));
        public IWebElement mobilePhoneField => Driver.FindElement(By.Id("phone_mobile"));
        public IWebElement firstNameField => Driver.FindElement(By.Id("customer_firstname"));
        public IWebElement lastNameField => Driver.FindElement(By.Id("customer_lastname"));
        public IWebElement addressField => Driver.FindElement(By.Id("address1"));
        public IWebElement passwordField => Driver.FindElement(By.Id("passwd"));
        public IWebElement cityField => Driver.FindElement(By.Id("city"));
        public IWebElement postalZipField => Driver.FindElement(By.Id("postcode"));
        public IWebElement stateField => Driver.FindElement(By.Id("id_state"));
        public IWebElement registerButton => Driver.FindElement(By.Id("submitAccount"));
        public IWebElement errorField => Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/div"));
    }
}
