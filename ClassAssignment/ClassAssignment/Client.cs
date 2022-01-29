using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        
        public Client(string FirstName, string LastName, string Email, string Address, string PhoneNUmber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        public Client()
        {
            FirstName = "Alexander";
            LastName = "Sauve";
            Email = "fahimhasan314@gmail.com";
            Address = "Nichu Colony";
            PhoneNumber = "+8801832788351";
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + "\n" +
                "LastName: " + LastName + "\n" +
                "Email: " + Email + "\n" +
                "Address: " + Address + "\n" +
                "PhoneNumber: " + PhoneNumber;
        }

    }
}