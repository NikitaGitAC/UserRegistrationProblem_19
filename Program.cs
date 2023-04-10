namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            password1rule Password = new password1rule();
            Console.WriteLine("Please enter password:");
            string passWord = Console.ReadLine();
            Console.WriteLine(Password.ValidatePassword(passWord));
        }
    }
}