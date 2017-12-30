using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.DraggablePage
{
    public partial class DraggablePage
    {
        public IWebElement DraggableElement {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));
            }
        }
        // New record way
        // public IWebElement DraggableElement => this.Driver.FindElement(By.Id("draggable"));


    }
}
