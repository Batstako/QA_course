using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.ResizablePage
{
    public static class ResizablePageAsserter
    {

        public static void AssertHorizontalChangeSize(this ResizablePage page) 
        {
            Assert.IsTrue(page.Width < page.ResizableElement.Size.Width);
            Assert.IsTrue(page.Height == page.ResizableElement.Size.Height);
        }

        public static void AssertVerticalChangeSize(this ResizablePage page)
        {
            Assert.IsTrue(page.Height < page.ResizableElement.Size.Height);
            Assert.IsTrue(page.Width == page.ResizableElement.Size.Width);
        }

        public static void AssertDiagonalChangeSize(this ResizablePage page)
        {
            Assert.IsTrue(page.Width < page.ResizableElement.Size.Width);
            Assert.IsTrue(page.Height < page.ResizableElement.Size.Height);
        }
    }
}
