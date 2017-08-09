using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace homework2_POM.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {
        }

        public string URL {
            get
            {
                return base.url + "sortable/";
            }
        }

        public void NavigateTo()
        {
            //this.Driver.Navigate().GoToUrl("http://demoqa.com/sortable/");
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }

        public void SortFirstAfterFifthElement(Actions builder)
        {

            var action = builder.DragAndDropToOffset(this.FirstSelectableElement, 0, 133);
            action.Perform();
        }

        public void SortSeventhElementBeforeFirstElement(Actions builder)
        {
            var action = builder.DragAndDropToOffset(this.SeventhSelectableElement, 0, -200);
            action.Perform();
        }
        public void SortSeventhElementBeforeFirstElementAndFirstElementBeforeSeventh(Actions builder)
        {
            this.SortSeventhElementBeforeFirstElement(builder);
            var action = builder.DragAndDropToOffset(this.FirstSelectableElement, 0, -35);
            action.Perform();
            
        }
    }
}
