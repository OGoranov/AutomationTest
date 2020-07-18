using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public IWebElement axisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        public IWebElement onlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public IWebElement onlyYBox => Driver.FindElement(By.Id("restrictedY"));
        public IWebElement containerRestriction => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
        public IWebElement container => Driver.FindElement(By.Id("containmentWrapper"));
        public IWebElement draggable => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));
    }
}
