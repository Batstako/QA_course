using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace homework2_POM.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
        }

        public string URL {
            get
            {
                return base.url + "draggable/";
            }
        }

        public void NavigateTo()
        {
            //this.Driver.Navigate().GoToUrl("http://demoqa.com/draggable/");
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }

        
    }
}
