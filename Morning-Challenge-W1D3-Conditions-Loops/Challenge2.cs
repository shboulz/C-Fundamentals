using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge_W1D3_Conditions_Loops
{
    public class Users
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int IDNumber { get; }
    
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
        public Users(string firstName, string lastname, int idNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastname;
            IDNumber = idNumber;
            DateOfBirth = dateOfBirth;
        }
        public Users()
        {

        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string GetUserName(string firstname, string lastName)
        {
            string fullName = $"{firstname} {lastName}";
            return fullName;
        }
        public int GetUserAge(DateTime dateOfBirth)
        {
            TimeSpan ageSpan = DateTime.Now - DateOfBirth;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return yearsOfAge;
        }
    }
}
