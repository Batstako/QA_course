using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public IWebElement ResizableElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }
        public IWebElement ResizableButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='resizable']/div[3]"));
            }
        }


    }


}
