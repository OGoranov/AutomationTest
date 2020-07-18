using DemoQA.Pages.Interactions.Draggable;
using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA.Pages.Interactions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void GoToAxisRestrictedTab()
        {
            axisRestrictedTab.Click();
        }
        public void GoToContainerRestrictionTab()
        {
            containerRestriction.Click();
        }
        public void DragAndDropXDiagonally(Actions Builder)
        {
            Builder.DragAndDropToOffset(onlyXBox, 100, 100).Perform();
        }
        public void DragAndDropYDiagonally(Actions Builder)
        {
            Builder.DragAndDropToOffset(onlyYBox, 100, 100).Perform();
        }
        public void DragAndDropOutOfBox(Actions Builder)
        {
            Builder.DragAndDropToOffset(draggable, 0, container.Size.Height - 100).Perform();
        }
    }
}
