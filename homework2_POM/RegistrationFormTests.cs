using homework2_POM.Models;
using homework2_POM.Pages.RegistrationPage;
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
    public class RegistrationFormTests
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]
        public void EndTests()
        {
            this.driver.Close();
            this.driver.Quit();
        }


        [Test]
        public void RegWithoutFirstName()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "012345678",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForRegWithoutFirstName("* This field is required");
        }
        [Test]
        public void RegWithoutLastName()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "012345678",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForRegWithoutFirstName("* This field is required");
        }
        [Test]
        public void RegWithoutHobbies()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, false, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "012345678",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForHobbies("* This field is required");
        }
        [Test]
        public void RegWithoutPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForPhone("* This field is required");
        }
        [Test]
        public void RegWithLessThan10DigitPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "123456789",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForPhone("* Minimum 10 Digits starting with Country Code");
        }
        [Test]
        public void RegWith10DigitPlusSymbolPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "+1234567890",
                                                         "Gogo",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWith10DigitAndPlusPhone("* Minimum 10 Digits starting with Country Code");
        }
        [Test]
        public void RegWithoutUserName()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "",
                                                         "gogo@abv.bg",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForUsername("* This field is required");
        }
        [Test]
        public void RegWithoutUserMail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageForMail("* This field is required");
        }
        [Test]
        public void RegWithInvalidUserMail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageInvalidMail("* Invalid email address");
        }
        [Test]
        public void RegWithInvalidUserMail_2()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageInvalidMail("* Invalid email address");
        }
        [Test]
        public void RegWithInvalidPic()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@.com",
                                                         @"E:\QA_automation\profilePicTest.pdf",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageInvalidPicFormat("* Invalid File");
        }
        [Test]
        public void RegWithInvalidPic_2()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.rar",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageInvalidPicFormat("* Invalid File");
        }
        [Test]
        public void RegWithWithoutPass()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "",
                                                         "123456789");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWithoutPass("* This field is required");
        }
        [Test]
        public void RegWithWithoutConfirmPass()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWithoutConfirmPass("* This field is required");
        }
        [Test]
        public void RegWithLessThan8CharsPass()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123",
                                                         "123");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWithLessThan8CharsPass("* Minimum 8 characters required");
        }
        [Test]
        public void RegWithMismatchPass()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "123456789",
                                                         "123");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWithMismatchConfirmPass("* Fields do not match");
        }
        [Test]
        public void RegWithoutoutPassAndConfirmPassFields()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Gogo",
                                                         "Gogov",
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         new List<bool>(new bool[] { false, true, false }),
                                                         "Bulgaria",
                                                         "3",
                                                         "10",
                                                         "1990",
                                                         "1234567890",
                                                         "Gogo",
                                                         "bla@bla.com",
                                                         @"E:\QA_automation\profilePicTest.jpg",
                                                         "Bla Bla Bla Bla Bla",
                                                         "",
                                                         "");
            regPage.Navigate();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageWithoutPassAndConfirmPass("* This field is required");
        }
    }
}
