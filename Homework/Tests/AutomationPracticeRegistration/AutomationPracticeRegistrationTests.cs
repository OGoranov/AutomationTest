using DemoQA.Models;
using DemoQA.Pages.AutomationPracticeRegistration;
using NUnit.Framework;

namespace DemoQA.Tests.AutomationPracticeRegistration
{
    [TestFixture]
    class AutomationPracticeRegistrationTests : BaseTest
    {
        private AutomationPracticeRegistrationPage _automationPracticeRegistrationPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _automationPracticeRegistrationPage = new AutomationPracticeRegistrationPage(Driver);
        }

        [Test]
        public void CorrectResultDisplayed_When_SearchingSeleniumInGoogle()
        {
            _automationPracticeRegistrationPage.SignIn();

            _automationPracticeRegistrationPage.AssertEmailAddress(_automationPracticeRegistrationPage.emailAddressField);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
