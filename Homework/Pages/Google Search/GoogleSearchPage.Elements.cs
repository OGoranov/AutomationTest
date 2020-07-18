using OpenQA.Selenium;

namespace DemoQA.Pages.PracticeForm
{
    public partial class GoogleSearchPage : BasePage
    {
        public IWebElement googleSearchTextField => Driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input"));
        public IWebElement googleSearchButton => Driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[3]/center/input[1]"));
        public IWebElement firstResult => Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div[1]/a/h3"));
    }
}
