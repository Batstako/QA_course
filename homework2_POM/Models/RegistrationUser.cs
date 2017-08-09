using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Models
{
    public class RegistrationUser
    {
        private String firstName;
        private String lastName;
        private List<bool> maritalStatus;
        private List<bool> hobbies;
        private String country;
        private String birthMonth;
        private String birthDay;
        private String birthYear;
        private String phoneNumber;
        private String userName;
        private String email;
        private String picture;
        private String aboutYourself;
        private String pass;
        private String confirmPass;

        public RegistrationUser ( String firstName,
                                  String lastName,
                                  List<bool> maritalStatus,
                                  List<bool> hobbies,
                                  String country,
                                  String birthMonth,
                                  String birthDay,
                                  String birthYear,
                                  String phoneNumber,
                                  String userName,
                                  String email,
                                  String picture,
                                  String aboutYourself,
                                  String pass,
                                  String confirmPass )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.maritalStatus = maritalStatus;
            this.hobbies = hobbies;
            this.country = country;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.birthYear = birthYear;
            this.phoneNumber = phoneNumber;
            this.userName = userName;
            this.email = email;
            this.picture = picture;
            this.aboutYourself = aboutYourself;
            this.pass = pass;
            this.confirmPass = confirmPass;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public List<bool> MaritalStatus
        {
            get { return this.maritalStatus; }
            set { this.maritalStatus = value; }
        }

        public List<bool> Hobbies
        {
            get { return this.hobbies; }
            set { this.hobbies = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string BirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }

        public string BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }

        public string BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        public string AboutYourself
        {
            get { return this.aboutYourself; }
            set { this.aboutYourself = value; }
        }

        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public string ConfirmPass
        {
            get { return this.confirmPass; }
            set { this.confirmPass = value; }
        }
    }
}
