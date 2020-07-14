using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    class Customer
    {
        internal DateTime DOB;
        internal string name;
        internal string gender;
        internal string emailID;
        internal string password;

        internal void Register(DateTime DOB, string name, string gender, string emailID, string password)
        {
            this.DOB = DOB;
            this.name = name;
            this.gender = gender;
            this.emailID = emailID;
            this.password = password;
        }

        internal void Display()
        {
            Console.WriteLine("Name: " + name + "\tEmail ID: " + emailID + "\tDate of Birth: " + DOB + "\tGender: " + gender);
        }
    }
}
