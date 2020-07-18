using DemoQA.Pages.Interactions.Draggable;
using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            _draggablePage = new DraggablePage(Driver);
        }

        [Test]
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
            _draggablePage.GoToAxisRestrictedTab();

            int yBefore = _draggablePage.onlyXBox.Location.Y;

            _draggablePage.DragAndDropXDiagonally(Builder);

            _draggablePage.AssertYLocation(yBefore, _draggablePage.onlyXBox);
        }

        [Test]
        public void ElementXIsSame_When_DragAndDropOnlyYDiagonally()
        {
            _draggablePage.GoToAxisRestrictedTab();

            int xBefore = _draggablePage.onlyYBox.Location.X;

            _draggablePage.DragAndDropXDiagonally(Builder);

            _draggablePage.AssertXLocation(xBefore, _draggablePage.onlyYBox);
        }

        [Test]
        public void ElementStillInBox_When_DragAndDropOutOfBox()
        {
            _draggablePage.GoToContainerRestrictionTab();

            _draggablePage.DragAndDropOutOfBox(Builder);

            _draggablePage.AssertIfElementStillInBox(_draggablePage.container);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
