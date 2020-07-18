using DemoQA.Factories;
using DemoQA.Models;
using DemoQA.Pages.PracticeForm;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace DemoQA.Tests.Google_Search
{
    [TestFixture]
    class GoogleSearchTests : BaseTest
    {
        private GoogleSearchPage _googleSearchPage;
        private GoogleSearchModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.google.com");
            _googleSearchPage = new GoogleSearchPage(Driver);
            _user = GoogleSearchFactory.Create();
        }

        [Test]
        public void CorrectResultDisplayed_When_SearchingSeleniumInGoogle()
        {
            _googleSearchPage.FillGoogleSearchField(_user);

            _googleSearchPage.AssertResultName(_googleSearchPage.firstResult);
        }
        [Test]
        public void CorrectURLDisplayed_When_FirstSeleniumResultIsClicked()
        {
            _googleSearchPage.ClickOnFirstResult(_user);

            _googleSearchPage.AssertResultURL(_googleSearchPage.Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
