using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertErrorMessageForRegWithoutFirstName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForFirstAndLastName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForFirstAndLastName.Text);
        }
        public static void AssertErrorMessageForRegWithoutLastName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForFirstAndLastName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForFirstAndLastName.Text);
        }
        public static void AssertErrorMessageForHobbies(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForHobby.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForHobby.Text);
        }
        public static void AssertErrorMessageForPhone(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }
        public static void AssertErrorMessageLessThan10DigitPhone(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }
        public static void AssertErrorMessageWith10DigitAndPlusPhone(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }
        public static void AssertErrorMessageForUsername(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForUserName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForUserName.Text);
        }
        public static void AssertErrorMessageForMail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmail.Text);
        }
        public static void AssertErrorMessageInvalidMail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmail.Text);
        }
        public static void AssertErrorMessageInvalidPicFormat(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidPicFormat.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForInvalidPicFormat.Text);
        }
        public static void AssertErrorMessageWithoutPass(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
        public static void AssertErrorMessageWithoutConfirmPass(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
        }
        public static void AssertErrorMessageWithLessThan8CharsPass(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
        public static void AssertErrorMessageWithMismatchConfirmPass(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
        }
        public static void AssertErrorMessageWithoutPassAndConfirmPass(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
    }
}
