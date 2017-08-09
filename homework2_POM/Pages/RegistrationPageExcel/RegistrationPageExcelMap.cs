using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.RegistrationPageExcel
{
    public partial class RegistrationPageExcel
    {
        public IWebElement FirstName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_firstname"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_lastname"));
            }
        }
        // samo za testa nasila da klikne marital status
        //public IWebElement MaritalStatus1
        //{
        //    get
        //    {
        //        return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[2]/div/div/input[3]"));
        //    }
        //}

        public List<IWebElement> MaritalStatus
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@id='pie_register']/li[2]/div/div/input[3]")));
                return Driver.FindElements(By.Name("radio_4[]")).ToList();
            }
        }

        public List<IWebElement> Hobbies
        {
            get
            {
                return Driver.FindElements(By.Name("checkbox_5[]")).ToList();
            }
        }

        private IWebElement CountryDD
        {
            get
            {
                return Driver.FindElement(By.Id("dropdown_7"));
            }
        }
        public SelectElement CountryOption
        {
            get
            {
                return new SelectElement(CountryDD);
            }
        }
        private IWebElement BirthMonth
        {
            get
            {
                return Driver.FindElement(By.Id("mm_date_8"));
            }
        }
        public SelectElement BirthMonthOption
        {
            get
            {
                return new SelectElement(BirthMonth);
            }
        }
        private IWebElement BirthDay
        {
            get
            {
                return Driver.FindElement(By.Id("dd_date_8"));
            }
        }
        public SelectElement BirthDayOption
        {
            get
            {
                return new SelectElement(BirthDay);
            }
        }
        private IWebElement BirthYear
        {
            get
            {
                return Driver.FindElement(By.Id("yy_date_8"));
            }
        }
        public SelectElement BirthYearOption
        {
            get
            {
                return new SelectElement(BirthYear);
            }
        }

        public IWebElement PhoneNumber
        {
            get
            {
                return Driver.FindElement(By.Id("phone_9"));
            }
        }

        public IWebElement UserName
        {
            get
            {
                return Driver.FindElement(By.Id("username"));
            }
        }
        public IWebElement Email
        {
            get
            {
                return Driver.FindElement(By.Id("email_1"));
            }
        }
        public IWebElement ProfilePicture
        {
            get
            {
                return Driver.FindElement(By.Id("profile_pic_10"));
            }
        }
        public IWebElement AboutYourself
        {
            get
            {
                return Driver.FindElement(By.Id("description"));
            }
        }
        public IWebElement Pass
        {
            get
            {
                return Driver.FindElement(By.Id("password_2"));
            }
        }
        public IWebElement ConfirmPass
        {
            get
            {
                return Driver.FindElement(By.Id("confirm_password_password_2"));
            }
        }
        public IWebElement SubmitButton
        {
            get
            {
                return Driver.FindElement(By.Name("pie_submit"));
            }
        }
        public IWebElement ErrorMessageForFirstAndLastName
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[1]/div[1]/div[2]/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[1]/div[1]/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageForHobby
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[3]/div/div[2]/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[3]/div/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageForPhoneNumber
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[6]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageForUserName
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[7]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[7]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageForEmail
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[8]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[8]/div/div/span"));
            }
        }

        public IWebElement ErrorMessageForInvalidPicFormat
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[9]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[9]/div/div/span"));
            }

        }
        public IWebElement ErrorMessageForPass
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[11]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageForConfirmPass
        {
            get
            {
                Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[12]/div/div/span")));
                return Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[12]/div/div/span"));
            }
        }


    }
}

