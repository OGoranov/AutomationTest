using DemoQA.Models;
using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Pages.PracticeForm
{
    public partial class GoogleSearchPage : BasePage
    {
        public void AssertResultName(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("Selenium", element.Text);
        }

        public void AssertResultURL(IWebDriver element)
        {
            this.WaitForLoad();
            Assert.AreEqual("https://www.selenium.dev/", element.Url);
        }
    }
}
