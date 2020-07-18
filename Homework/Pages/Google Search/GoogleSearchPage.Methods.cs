using DemoQA.Models;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQA.Pages.PracticeForm
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public void FillGoogleSearchField(GoogleSearchModel user)
        {
            googleSearchTextField.SendKeys(user.SearchElement);

            googleSearchTextField.SendKeys(Keys.Enter);
        }
        
        public void ClickOnFirstResult(GoogleSearchModel user)
        {
            FillGoogleSearchField(user);

            firstResult.Click();
        }
    }
}
