using System;

namespace ValidationUsingRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation validation = new RegexValidation();
            Console.WriteLine(validation.ValidateName("Management"));
            Console.WriteLine(validation.ValidateEmail("mmmmm1234@gmail.com"));
            Console.WriteLine(validation.ValidMobileNumber("7894561232"));
            Console.WriteLine(validation.ValidPassword("abcdefgh"));
        }
    }
}
