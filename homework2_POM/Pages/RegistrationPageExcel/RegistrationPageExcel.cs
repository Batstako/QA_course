using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using homework2_POM.Models;
using System.Threading;

namespace homework2_POM.Pages.RegistrationPageExcel
{
    public partial class RegistrationPageExcel : BasePage
    {
        public RegistrationPageExcel(IWebDriver driver) : base(driver)
        {
        }

        public string URL {
            get
            {
                return base.url + "registration/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }

        public void FillRegistrationFormExcel(RegistrationUserExcel user)
        {

            this.Typing(this.FirstName, user.FirstName);
            this.Typing(this.LastName, user.LastName);
            this.ClickOnElements(this.MaritalStatus, user.MaritalStatus);
            this.ClickOnElements(this.Hobbies, user.Hobbies);
            this.CountryOption.SelectByText(user.Country);
            this.BirthMonthOption.SelectByText(user.BirthMonth);
            this.BirthDayOption.SelectByText(user.BirthDay);
            this.BirthYearOption.SelectByText(user.BirthYear);
            this.Typing(this.PhoneNumber, user.PhoneNumber);
            this.Typing(this.UserName, user.UserName);
            this.Typing(this.Email, user.Email);
            this.Typing(this.ProfilePicture, user.Picture);
            this.Typing(this.AboutYourself, user.AboutYourself);
            this.Typing(this.Pass, user.Pass);
            this.Typing(this.ConfirmPass, user.ConfirmPass);
            this.SubmitButton.Click();

            //this.FirstName.SendKeys(user.FirstName);
            //this.LastName.SendKeys(user.LastName);

        }

        private void Typing(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        private void ClickOnElements(List<IWebElement> element, string conditionsFromExcel)
        {
            var conditions = conditionsFromExcel.Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < element.Count; i++)
            {
                if (conditions[i] == 1)
                {
                    element[i].Click();
                }
            }

        }
    }
}
