namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            passwordrule2 Password = new passwordrule2();
            Console.WriteLine("Please enter the password:");
            string password = Console.ReadLine();
            Console.WriteLine(Password.ValidatePassword(password));
        
        }
    }
}