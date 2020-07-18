using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Pages.AutomationPractice
{
    public partial class AutomationPracticePage : BasePage
    {
        public void AssertErrorFieldDisplayed(IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsTrue(element.Displayed);
        }
    }
}
