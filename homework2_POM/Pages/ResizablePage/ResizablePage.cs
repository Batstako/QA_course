using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace homework2_POM.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        private int width;
        private int height;

        public ResizablePage(IWebDriver driver) : base(driver)
        {
        }

        public string URL {
            get
            {
                return base.url + "resizable/";
            }
        }

        public int Width {
            get
            {
                return this.width;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
        }

        public void NavigateTo()
        {
            //this.Driver.Navigate().GoToUrl("http://demoqa.com/resizable/");
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }

        public void ResizeElementByWidthAndHeight(int width, int height)
        {
            this.width = this.ResizableElement.Size.Width;
            this.height = this.ResizableElement.Size.Height;
            Actions builder = new Actions(this.Driver);
            var resize = builder.DragAndDropToOffset(this.ResizableButton, width, height);
            resize.Perform();
        }

    }
}
