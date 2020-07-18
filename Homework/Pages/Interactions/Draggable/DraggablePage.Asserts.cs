using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public void AssertYLocation(int yBefore, IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual(yBefore, element.Location.Y);
        }
        public void AssertXLocation(int xBefore, IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual(xBefore, element.Location.X);
        }
        public void AssertIfElementStillInBox(IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsNotNull(element.FindElement(By.TagName("div")));
        }
    }
}
