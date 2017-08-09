using homework2_POM.Models;
using homework2_POM.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }



        public void Navigate()
       {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
            this.Driver.Manage().Window.Maximize();
        }


        public void FillRegistrationForm(RegistrationUser user)
        {
            Typing(this.FirstName, user.FirstName); //this.FirstName е елемента, user.FirstName е пропъртито на user-а

            Typing(this.LastName, user.LastName);
            //this.MaritalStatus1.Click();

            ClickOnElements(this.MaritalStatus, user.MaritalStatus);
            ClickOnElements(this.Hobbies, user.Hobbies);
            this.CountryOption.SelectByText(user.Country);
            this.BirthMonthOption.SelectByText(user.BirthMonth);
            this.BirthDayOption.SelectByText(user.BirthDay);
            this.BirthYearOption.SelectByText(user.BirthYear);
            Typing(this.PhoneNumber, user.PhoneNumber);
            Typing(this.UserName, user.UserName);
            Typing(this.Email, user.Email);
            this.ProfilePicture.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(user.Picture);
            Typing(this.AboutYourself, user.AboutYourself);
            Typing(this.Pass, user.Pass);
            Typing(this.ConfirmPass, user.ConfirmPass);
            // samo za test da klikne marital status

            this.SubmitButton.Click();
        }

        private void ClickOnElements(List<IWebElement> elements, List<bool> list)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (list[i])
                {
                    elements[i].Click();
                }
            }
        }

        private void Typing(IWebElement elem, string text)
        {
            elem.Clear();
            elem.SendKeys(text);

        }

    }
}
