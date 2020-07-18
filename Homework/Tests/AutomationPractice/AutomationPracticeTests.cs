using DemoQA.Factories;
using DemoQA.Models;
using DemoQA.Pages.AutomationPractice;
using DemoQA.Pages.PracticeForm;
using NUnit.Framework;

namespace DemoQA.Tests.AutomationPractice
{
    [TestFixture]
    public class AutomationPracticeTests : BaseTest
    {
        private AutomationPracticePage _automationPracticePage;
        private AutomationPracticeModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _automationPracticePage = new AutomationPracticePage(Driver);
            _user = AutomationPracticeFactory.Create();
        }

        [Test]
        public void ErrorMessageDisplayed_When_EmailIsIncorrect()
        {
            _user.emailAddressField = "$$$4";

            _automationPracticePage.FillForm(_user);

            _automationPracticePage.AssertErrorFieldDisplayed(_automationPracticePage.errorField);
        }

        [Test]
        public void ErrorMessageDisplayed_When_ZipCodeIsIncorrect()
        {
            _user.postalZipField = "1234";

            _automationPracticePage.FillForm(_user);

            _automationPracticePage.AssertErrorFieldDisplayed(_automationPracticePage.errorField);
        }

        [Test]
        public void ErrorMessageDisplayed_When_FirstNameIsIncorrect()
        {
            _user.firstNameField = "1234";

            _automationPracticePage.FillForm(_user);

            _automationPracticePage.AssertErrorFieldDisplayed(_automationPracticePage.errorField);
        }

        [Test]
        public void ErrorMessageDisplayed_When_PhoneNumberIsIncorrect()
        {
            _user.mobilePhoneField = "RandomNumber";

            _automationPracticePage.FillForm(_user);

            _automationPracticePage.AssertErrorFieldDisplayed(_automationPracticePage.errorField);
        }

        [Test]
        public void ErrorMessageDisplayed_When_CityIsEmpty()
        {
            _user.cityField = string.Empty;

            _automationPracticePage.FillForm(_user);

            _automationPracticePage.AssertErrorFieldDisplayed(_automationPracticePage.errorField);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
