using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace DemoQA.Pages.QA_Automation
{
    public partial class QAAutomationPage : BasePage
    {
        public IWebElement BurgerButton => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[2]/ul/li[1]/a/span/i"));
        public IWebElement PlusButton => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]/i"));
        public IWebElement Training => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span"));
        public IWebElement QA => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[2]/div[1]/ul/li/h2/a"));
        public IWebElement QAAutomation => Driver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div[2]/div[3]/div/a/div[1]"));
        public IWebElement Text => Driver.FindElement(By.TagName("h1"));
    }
}
