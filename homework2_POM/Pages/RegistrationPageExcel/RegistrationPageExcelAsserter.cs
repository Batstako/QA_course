using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.RegistrationPageExcel
{
    public static class RegistrationPageExcelAsserter
    {
        public static void AssertErrorMessageForRegWithoutFirstAndLastName(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForFirstAndLastName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForFirstAndLastName.Text);
        }

        public static void AssertErrorMessageForHobbies(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForHobby.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForHobby.Text);
        }

        public static void AssertErrorMessageForPhone(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }

        public static void AssertErrorMessageLessThan10DigitPhone(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }

        public static void AssertErrorMessageWith10DigitAndPlusPhone(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPhoneNumber.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPhoneNumber.Text);
        }

        public static void AssertErrorMessageForUsername(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForUserName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForUserName.Text);
        }
        public static void AssertErrorMessageForMail(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmail.Text);
        }
        public static void AssertErrorMessageInvalidMail(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForEmail.Text);
        }
        public static void AssertErrorMessageInvalidPicFormat(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidPicFormat.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForInvalidPicFormat.Text);
        }
        public static void AssertErrorMessageWithoutPass(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
        public static void AssertErrorMessageWithoutConfirmPass(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
        }
        public static void AssertErrorMessageWithLessThan8CharsPass(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
        public static void AssertErrorMessageWithMismatchConfirmPass(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
        }
        public static void AssertErrorMessageWithoutPassAndConfirmPass(this RegistrationPageExcel page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForConfirmPass.Displayed);
            Assert.IsTrue(page.ErrorMessageForPass.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForConfirmPass.Text);
            Assert.AreEqual(text, page.ErrorMessageForPass.Text);
        }
    }
}
