using homework2_POM.Pages.DraggablePage;
using homework2_POM.Pages.Droppable;
using homework2_POM.Pages.ResizablePage;
using homework2_POM.Pages.SelectablePage;
using homework2_POM.Pages.SortablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM
{
    [TestFixture]
    public class ToolsQATests
    {
        private IWebDriver driver;

        [TearDown]
        public void EndTests()
        {
            this.driver.Close();
            this.driver.Quit();
        }

        [Test]
        [Property("Draggable", 3)]
        public void DragRight()
        {
            this.driver = new ChromeDriver();
            DraggablePage draggablePageRight = new DraggablePage(this.driver);

            draggablePageRight.NavigateTo();
            //this.driver.Manage().Window.Maximize();
            int positionX = draggablePageRight.DraggableElement.Location.X;
            int positionY = draggablePageRight.DraggableElement.Location.Y;
            Actions builder = new Actions(this.driver);
            builder.DragAndDropToOffset(draggablePageRight.DraggableElement, 100, 0).Perform();

            Assert.IsTrue((draggablePageRight.DraggableElement.Location.X > positionX) && (draggablePageRight.DraggableElement.Location.Y == positionY));
        }

        [Test]
        [Property("Draggable", 3)]
        public void DragLeft()
        {
            this.driver = new ChromeDriver();
            DraggablePage draggablePageLeft = new DraggablePage(this.driver);

            draggablePageLeft.NavigateTo();
            //this.driver.Manage().Window.Maximize(); 
            int positionX = draggablePageLeft.DraggableElement.Location.X;
            int positionY = draggablePageLeft.DraggableElement.Location.Y;
            Actions builder = new Actions(this.driver);
            builder.DragAndDropToOffset(draggablePageLeft.DraggableElement, -100, 0).Perform();

            Assert.IsTrue((draggablePageLeft.DraggableElement.Location.X < positionX) && (draggablePageLeft.DraggableElement.Location.Y == positionY));
        }

        [Test]
        [Property("Draggable", 3)]
        public void DragUp()
        {
            this.driver = new ChromeDriver();
            DraggablePage draggablePageUp = new DraggablePage(this.driver);

            draggablePageUp.NavigateTo();
            int positionX = draggablePageUp.DraggableElement.Location.X;
            int positionY = draggablePageUp.DraggableElement.Location.Y;
            Actions builder = new Actions(this.driver);
            builder.DragAndDropToOffset(draggablePageUp.DraggableElement, 0, -100).Perform();

            Assert.IsTrue((draggablePageUp.DraggableElement.Location.Y < positionY) && (draggablePageUp.DraggableElement.Location.X == positionX));
        }

        [Test]
        [Property("Draggable", 3)]
        public void DragDown()
        {
            this.driver = new ChromeDriver();
            DraggablePage draggablePageDown = new DraggablePage(this.driver);

            draggablePageDown.NavigateTo();
            int positionX = draggablePageDown.DraggableElement.Location.X;
            int positionY = draggablePageDown.DraggableElement.Location.Y;
            Actions builder = new Actions(this.driver);
            builder.DragAndDropToOffset(draggablePageDown.DraggableElement, 0, 100).Perform();

            Assert.IsTrue((draggablePageDown.DraggableElement.Location.X == positionX) && (draggablePageDown.DraggableElement.Location.Y > positionY));
        }

        [Test]
        [Property("Draggable", 3)]
        public void DragDiagonal()
        {
            this.driver = new ChromeDriver();
            DraggablePage draggablePageDiagonal = new DraggablePage(this.driver);

            draggablePageDiagonal.NavigateTo();
            int positionX = draggablePageDiagonal.DraggableElement.Location.X;
            int positionY = draggablePageDiagonal.DraggableElement.Location.Y;
            Actions builder = new Actions(this.driver);
            builder.DragAndDropToOffset(draggablePageDiagonal.DraggableElement, 100, 100).Perform();

            Assert.IsTrue((draggablePageDiagonal.DraggableElement.Location.X > positionX) && (draggablePageDiagonal.DraggableElement.Location.Y > positionY));
        }

        [Test]
        [Property("Droppable", 3)]
        public void DroppableIn()
        {
            this.driver = new ChromeDriver();
            DroppablePage page = new DroppablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(page.SourceElement, page.TargetElement).Perform();

            Assert.AreEqual("ui-widget-header ui-droppable ui-state-highlight", page.TargetElement.GetAttribute("class"));
        }

        [Test]
        [Property("Droppable", 3)]
        public void DroppedOut()
        {
            this.driver = new ChromeDriver();
            DroppablePage page = new DroppablePage(this.driver);

            page.NavigateTo();
            int positionY = page.SourceElement.Location.Y;
            Actions builder = new Actions(this.driver);
            var drag = builder.DragAndDropToOffset(page.SourceElement, 0, 150);
            drag.Perform();

            Assert.AreEqual("ui-widget-header ui-droppable", page.TargetElement.GetAttribute("class"));
            Assert.IsTrue(positionY < page.SourceElement.Location.Y);
        }

        [Test]
        [Property("Droppable", 3)]
        public void AcceptDraggedButNotDropped()
        {
            this.driver = new ChromeDriver();
            DroppablePage page = new DroppablePage(this.driver);

            page.NavigateTo();
            page.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(page.AcceptSourceElement, page.AcceptTargetElement).Perform();

            Assert.AreEqual("accept: ‘#draggableaccept’", page.AcceptTargetElement.Text);
        }

        [Test]
        [Property("Droppable", 3)]
        public void AcceptDraggedAndDropped()
        {
            this.driver = new ChromeDriver();
            DroppablePage page = new DroppablePage(this.driver);

            page.NavigateTo();
            page.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(page.AcceptSourceElement2, page.AcceptTargetElement).Perform();

            Assert.AreEqual("Dropped!", page.AcceptTargetElement.Text);
        }

        [Test]
        [Property("Droppable", 3)]
        public void AcceptDraggedAndDroppedAndNotDropped()
        {
            this.driver = new ChromeDriver();
            DroppablePage page = new DroppablePage(this.driver);

            page.NavigateTo();
            page.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(page.AcceptSourceElement, page.AcceptTargetElement).Perform();

            Assert.AreEqual("accept: ‘#draggableaccept’", page.AcceptTargetElement.Text);

            builder.DragAndDrop(page.AcceptSourceElement2, page.AcceptTargetElement).Perform();

            Assert.AreEqual("Dropped!", page.AcceptTargetElement.Text);
        }

        [Test]
        [Property("Resizable", 3)]
        public void HorizontalResize()
        {
            this.driver = new ChromeDriver();
            ResizablePage page = new ResizablePage(this.driver);

            page.NavigateTo();
            //var positionX = page.ResizableElement.Location.X;
            //var positionY = page.ResizableElement.Location.Y;
            //Actions builder = new Actions(this.driver);
            //builder.DragAndDropToOffset(page.ResizableButton, 200, 0).Perform();
            page.ResizeElementByWidthAndHeight(100, 0);
            //Assert.IsTrue((positionX < page.ResizableElement.Location.X) && (positionY == page.ResizableElement.Location.Y));
            page.AssertHorizontalChangeSize();
        }

        [Test]
        [Property("Resizable", 3)]
        public void VertikalResize()
        {
            this.driver = new ChromeDriver();
            ResizablePage page = new ResizablePage(this.driver);

            page.NavigateTo();
            page.ResizeElementByWidthAndHeight(0, 100);

            page.AssertVerticalChangeSize();
        }

        [Test]
        [Property("Resizable", 3)]
        public void DiagonalResize()
        {
            this.driver = new ChromeDriver();
            ResizablePage page = new ResizablePage(this.driver);

            page.NavigateTo();
            page.ResizeElementByWidthAndHeight(100, 100);

            page.AssertDiagonalChangeSize();
        }

        [Test]
        [Property("Selectable", 3)]
        public void SelectFirstAndLastElement()
        {
            this.driver = new ChromeDriver();
            SelectablePage page = new SelectablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            //var action = builder.MoveToElement(page.SelectableFirstElement).Click()
            //                                                               .KeyDown(Keys.Control)
            //                                                               .MoveToElement(page.SelectableLastElement)
            //                                                               .Click()
            //                                                               .KeyUp(Keys.Control); ;
            ////var action2 = builder.KeyDown(Keys.Control)
            ////    .MoveToElement(page.SelectableLastElement)
            ////                                         .Click()
            ////                                         .KeyUp(Keys.Control);

            //action.Perform();
            ////action2.Perform();
            page.Select2Elements(builder);
            page.AssertFirstAndLastElementAreClicked("ui-widget-content ui-corner-left ui-selectee ui-selected");

        }

        [Test]
        [Property("Selectable", 3)]
        public void SelectTwoElementsAndDeselectLast()
        {
            this.driver = new ChromeDriver();
            SelectablePage page = new SelectablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            page.Select2ElementsAndDeselectSecond(builder);

            page.AssertCheckIfSecondElementIsDeselected("ui-widget-content ui-corner-left ui-selectee", "ui-widget-content ui-corner-left ui-selectee ui-selected");
        }

        [Test]
        [Property("Selectable", 3)]
        public void DeselectTwoSelectedElements()
        {
            this.driver = new ChromeDriver();
            SelectablePage page = new SelectablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            page.Deselect2SelectedElements(builder);

            page.AssertCheckIfTwoElementsAreDeselected("ui-widget-content ui-corner-left ui-selectee");
        }

        [Test]
        [Property("Sortable", 3)]
        public void SortFirstElementAfterFifthElement()
        {
            this.driver = new ChromeDriver();
            SortablePage page = new SortablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            page.SortFirstAfterFifthElement(builder);

            page.AssertFirstelementIsAfterFifthElement();
        }

        [Test]
        [Property("Sortable", 3)]
        public void SortSeventhElementBeforeFirstElement()
        {
            this.driver = new ChromeDriver();
            SortablePage page = new SortablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            page.SortSeventhElementBeforeFirstElement(builder);

            page.AssertSeventhElementIsBeforeFirstElement();
        }

        [Test]
        [Property("Sortable", 3)]
        public void SortSeventhElementBeforeFirstElementAndFirstElementBeforeSeventh()
        {
            this.driver = new ChromeDriver();
            SortablePage page = new SortablePage(this.driver);

            page.NavigateTo();
            Actions builder = new Actions(this.driver);
            page.SortSeventhElementBeforeFirstElementAndFirstElementBeforeSeventh(builder);

            page.AssertFirstAndSeventhElementsAreFirstAndSecondInList();            
        }


    }
}
