using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.SortablePage
{
    public partial class SortablePage
    {
        public IWebElement FirstSelectableElement
        {
            get
            {

                this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='sortable']/li[text()='Item 1']")));
                return this.Driver.FindElement(By.XPath(".//ul[@id='sortable']/li[text()='Item 1']"));
                
            }
        }

        public IWebElement SeventhSelectableElement
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='sortable']/li[text()='Item 7']")));
                return this.Driver.FindElement(By.XPath(".//ul[@id='sortable']/li[text()='Item 7']"));
            }
        }

        public IWebElement FifthSelectableElement
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='sortable']/li[text()='Item 5']")));
                return this.Driver.FindElement(By.XPath(".//ul[@id='sortable']/li[text()='Item 5']"));
            }
        }
        public IWebElement SixthSelectableElement
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='sortable']/li[text()='Item 6']")));
                return this.Driver.FindElement(By.XPath(".//ul[@id='sortable']/li[text()='Item 6']"));
            }
        }
        public IWebElement SecondSelectableElement
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='sortable']/li[text()='Item 2']")));
                return this.Driver.FindElement(By.XPath(".//ul[@id='sortable']/li[text()='Item 2']"));
            }
        }

    }
}
