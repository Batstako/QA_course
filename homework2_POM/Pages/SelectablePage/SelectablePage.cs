using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace homework2_POM.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }

        public string URL {
            get
            {
                return base.url + "selectable/";
            }
        }

        public void NavigateTo()
        {
            //this.Driver.Navigate().GoToUrl("http://demoqa.com/selectable/");
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }

        public void Select2Elements(Actions builder)
        {
            //Actions builder = new Actions(this.Driver);
            var select = builder.MoveToElement(this.SelectableFirstElement).Click()
                                                                           .KeyDown(Keys.Control)
                                                                           .MoveToElement(this.SelectableLastElement)
                                                                           .Click()
                                                                           .KeyUp(Keys.Control);
            select.Perform();
        }
        public void Select2ElementsAndDeselectSecond(Actions builder)
        {
            //Actions builder = new Actions(this.Driver);
            Select2Elements(builder);
            var deselectSecondElement = builder.MoveToElement(this.SelectableLastElement).KeyDown(Keys.Control)
                                                             .Click()
                                                             .KeyUp(Keys.Control);
            deselectSecondElement.Perform();

        }
        public void Deselect2SelectedElements(Actions builder)
        {
            Select2ElementsAndDeselectSecond(builder);
            var deselectFirstElement = builder.MoveToElement(this.SelectableFirstElement)
                                              .KeyDown(Keys.Control)
                                              .Click()
                                              .KeyUp(Keys.Control);
            deselectFirstElement.Perform();
            
        }
    }
}
