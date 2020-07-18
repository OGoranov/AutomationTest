using DemoQA.Models;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQA.Pages.QA_Automation
{
    public partial class QAAutomationPage : BasePage
    {
        public QAAutomationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void FindQAAutomation2020()
        {
            BurgerButton.Click();

            Training.Click();

            PlusButton.Click();

            QA.Click();

            QAAutomation.Click();

            Text.Click();
        }
    }
}
