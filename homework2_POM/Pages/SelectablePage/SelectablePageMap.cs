using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace homework2_POM.Pages.SelectablePage
{
    public partial class SelectablePage 
    {
        public IWebElement SelectableFirstElement {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable']/li[1]"));
            }
        }
        public IWebElement SelectableLastElement {
            get
            {
                return this.Driver.FindElement(By.XPath(".//ol[@id = 'selectable']/li[text()='Item 7']"));
            }
        }
    }
}
