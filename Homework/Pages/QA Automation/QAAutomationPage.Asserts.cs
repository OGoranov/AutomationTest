using DemoQA.Models;
using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Pages.QA_Automation
{
    public partial class QAAutomationPage : BasePage
    {
        public void AssertResultName(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("QA Automation - май 2020", element.Text);
        }
    }
}
