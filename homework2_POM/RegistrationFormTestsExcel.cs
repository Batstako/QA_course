using homework2_POM.Models;
using homework2_POM.Pages.RegistrationPageExcel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM
{
    [TestFixture]
    public class RegistrationFormTestsExcel
    {
        private IWebDriver driver;

        [TearDown]
        public void EndTests()
        {
            this.driver.Close();
            this.driver.Quit();
        }

        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegistretionWithoutFirstName()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("registrationWithoutFirstName"); // !!!!!!!!! "registrationWithoutFirstName" = key/първата колона от екселската таблица, така "захапва" конкретния ред за теста
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForRegWithoutFirstAndLastName("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutLastName()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutLastName");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForRegWithoutFirstAndLastName("* This field is required");

        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutHobbies()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutHobbies");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForHobbies("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutPhone()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutPhone");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForPhone("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithLessThan10DigitPhone()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithLessThan10DigitPhone");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageLessThan10DigitPhone("* Minimum 10 Digits starting with Country Code");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWith10DigitPlusSymbolPhone()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWith10DigitPlusSymbolPhone");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWith10DigitAndPlusPhone("* Minimum 10 Digits starting with Country Code");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutUserName()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutUserName");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForUsername("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutUserMail()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutUserMail");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageForMail("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithInvalidUserMail()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithInvalidUserMail");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageInvalidMail("* Invalid email address");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithInvalidUserMail_2()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithInvalidUserMail_2");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageInvalidMail("* Invalid email address");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithInvalidPic()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithInvalidPic");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageInvalidPicFormat("* Invalid File");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithInvalidPic_2()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithInvalidPic_2");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageInvalidPicFormat("* Invalid File");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithWithoutPass()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithWithoutPass");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWithoutPass("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithWithoutConfirmPass()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithWithoutConfirmPass");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWithoutConfirmPass("* This field is required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithLessThan8CharsPass()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithLessThan8CharsPass");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWithLessThan8CharsPass("* Minimum 8 characters required");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithMismatchPass()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithMismatchPass");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWithMismatchConfirmPass("* Fields do not match");
        }
        [Test]
        [Property("RegistrationFormTestsExcel", 2)]
        public void RegWithoutoutPassAndConfirmPassFields()
        {
            this.driver = new ChromeDriver();
            RegistrationPageExcel page = new RegistrationPageExcel(this.driver);

            page.NavigateTo();
            var registrationUser = AccessExcelData.GetData("RegWithoutoutPassAndConfirmPassFields");
            page.FillRegistrationFormExcel(registrationUser);

            page.AssertErrorMessageWithoutPassAndConfirmPass("* This field is required");
        }


    }
}
