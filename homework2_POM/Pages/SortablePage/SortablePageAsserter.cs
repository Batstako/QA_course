using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.SortablePage
{
    public static class SortablePageAsserter
    {
        public static void AssertFirstelementIsAfterFifthElement(this SortablePage page)
        {
            Assert.IsTrue((page.FifthSelectableElement.Location.Y < page.FirstSelectableElement.Location.Y) && page.SixthSelectableElement.Location.Y > page.FirstSelectableElement.Location.Y);
        }

        public static void AssertSeventhElementIsBeforeFirstElement(this SortablePage page)
        {
            Assert.IsTrue(page.SeventhSelectableElement.Location.Y < page.FirstSelectableElement.Location.Y);
        }

        public static void AssertFirstAndSeventhElementsAreFirstAndSecondInList(this SortablePage page)
        {
            Assert.IsTrue(page.SeventhSelectableElement.Location.Y > page.FirstSelectableElement.Location.Y);
            Assert.IsTrue(page.SeventhSelectableElement.Location.Y < page.SecondSelectableElement.Location.Y);
        }
    }
}
