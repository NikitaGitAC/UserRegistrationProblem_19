namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            Console.WriteLine("Welcome to the User Registration Page");
            validateemail eMail = new validateemail();
            Console.WriteLine("Please enter the email:");
            string email = Console.ReadLine();
            Console.WriteLine(eMail.validateEmail(email));
        }
    }
}