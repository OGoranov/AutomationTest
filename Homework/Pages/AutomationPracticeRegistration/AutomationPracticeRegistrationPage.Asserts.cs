using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public void AssertEmailAddress(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("testaccount123@abv.bg", element.GetAttribute("value"));
        }
    }
}
