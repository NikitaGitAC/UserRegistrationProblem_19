namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            passwordrule3 passWord = new passwordrule3();
            Console.WriteLine("Please Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine(passWord.ValidatePassword(password));

        }
    }
}