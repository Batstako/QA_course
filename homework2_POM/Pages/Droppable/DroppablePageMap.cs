using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.Droppable
{
    public partial class DroppablePage
    {
        public IWebElement SourceElement {
            get
            {
                return this.Driver.FindElement(By.Id("draggableview"));
            }
        }
        public IWebElement TargetElement {
            get
            {
                //this.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("droppableview")));
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }
        public IWebElement AcceptButton {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement AcceptSourceElement {
            get
            {
                return this.Driver.FindElement(By.Id("draggable-nonvalid"));
            }
        }
        public IWebElement AcceptTargetElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableaccept"));
            }
        }
        public IWebElement AcceptSourceElement2
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableaccept"));
            }
        }
    }
}
