using ClassAssignment;

class Program
{
     public static void Main(string[] args)
    {
        string FirstName = string.Empty;
        while (Validator.FieldIsEmpty(FirstName))
        {
            Console.WriteLine("Please enter the client first name: ");
            FirstName = Console.ReadLine();
        }

        string LastName = string.Empty;
        while (Validator.FieldIsEmpty(LastName))
        {
            Console.WriteLine("Please enter the client last name: ");
            LastName = Console.ReadLine();
        }
        string Email = string.Empty;
        while(Validator.FieldIsEmpty(Email) || !Validator.EmailIsValid(Email))
        {
            Console.WriteLine("Please enter the client email: ");
            Email = Console.ReadLine();
        }
        string Address = string.Empty;
        while (Validator.FieldIsEmpty(Address))
        {
            Console.WriteLine("Please enter the client address: ");
            Address = Console.ReadLine();
        }
        string PhoneNumber = string.Empty;
        while(Validator.FieldIsEmpty(PhoneNumber) || Validator.PhoneNumberIsValid(PhoneNumber))
        {
            Console.WriteLine("Please enter the client phonenumber: ");
            PhoneNumber = Console.ReadLine();
        }

        Client NewClient = new Client(FirstName, LastName, Email, Address, PhoneNumber);
        Console.Write(NewClient.ToString());
        Console.ReadKey();

    }
}


