using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.SelectablePage
{
    public static class SelectablePageAsserter
    {
        public static void AssertFirstAndLastElementAreClicked( this SelectablePage page, string text)
        {
            Assert.AreEqual(text, page.SelectableFirstElement.GetAttribute("class"));
            Assert.AreEqual(text, page.SelectableLastElement.GetAttribute("class"));
        }
        public static void AssertCheckIfSecondElementIsDeselected(this SelectablePage page, string text, string text2)
        {
            Assert.AreEqual(text, page.SelectableLastElement.GetAttribute("class"));
            Assert.AreEqual(text2, page.SelectableFirstElement.GetAttribute("class"));
        }
        public static void AssertCheckIfTwoElementsAreDeselected(this SelectablePage page, string text)
        {
            Assert.AreEqual(text, page.SelectableLastElement.GetAttribute("class"));
            Assert.AreEqual(text, page.SelectableFirstElement.GetAttribute("class"));
        }
    }
}
