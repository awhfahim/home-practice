using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class Validator
    {
        public static bool FieldIsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
                return true;
            return false;
        }
        public static bool PhoneNumberIsValid(string PhoneNumber)
        {
            if (PhoneNumber.Length == 14)
                return true;
            return false;
        }

        public static bool EmailIsValid(string Email)
        {
            if (Email.Contains("fahimhasan314@gmail.com"))
                return true;
            return false;
        }
    }
}
