using DemoQA.Factories;
using DemoQA.Models;
using DemoQA.Pages.PracticeForm;
using DemoQA.Pages.QA_Automation;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace DemoQA.Tests.QA_Automation
{
    [TestFixture]
    class QAAutomationTests : BaseTest
    {
        private QAAutomationPage _QAAutomationPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://softuni.bg");
            _QAAutomationPage = new QAAutomationPage(Driver);
        }

        [Test]
        public void CorrectHeadingTagIsDisplayed()
        {
            _QAAutomationPage.FindQAAutomation2020();

            _QAAutomationPage.AssertResultName(_QAAutomationPage.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
