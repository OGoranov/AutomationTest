using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public IWebElement signInButton => Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        public IWebElement emailAddressField => Driver.FindElement(By.CssSelector("#email_create"));
        public IWebElement createAnAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate > span"));
        public IWebElement emailAddressFieldInRegForm => Driver.FindElement(By.Id("email"));
    }
}
