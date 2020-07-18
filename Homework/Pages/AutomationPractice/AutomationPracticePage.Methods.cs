using DemoQA.Models;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace DemoQA.Pages.AutomationPractice
{
    public partial class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void SignIn()
        {
            signInButton.Click();

            emailAddressBox.SendKeys("testaccount123@abvgd.bg");

            createAnAccountButton.Click();
            createAnAccountButton.Click();
            createAnAccountButton.Click();
        }
        
        public void FillForm(AutomationPracticeModel user)
        {
            SignIn();

            this.WaitLoad();
            emailAddressField.SendKeys(user.emailAddressField);
            mobilePhoneField.SendKeys(user.mobilePhoneField);
            firstNameField.SendKeys(user.firstNameField);
            lastNameField.SendKeys(user.lastNameField);
            addressField.SendKeys(user.addressField);
            passwordField.SendKeys(user.passwordField);
            cityField.SendKeys(user.cityField);
            postalZipField.SendKeys(user.postalZipField);
            var selectElement = new SelectElement(stateField);
            selectElement.SelectByText(user.stateField);

            registerButton.Click();
        }
    }
}
