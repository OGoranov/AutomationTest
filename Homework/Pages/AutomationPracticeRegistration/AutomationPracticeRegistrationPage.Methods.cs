using DemoQA.Models;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQA.Pages.AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public AutomationPracticeRegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }
        public void SignIn()
        {
            signInButton.Click();

            emailAddressField.SendKeys("testaccount123@abv.bg");

            createAnAccountButton.Click();
        }
    }
}
