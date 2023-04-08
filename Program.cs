namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            Console.WriteLine("Welcome to the User Registration Page");
            validlastname name = new validlastname();
            Console.WriteLine("Enter Last Name");
            string LName = Console.ReadLine();
            Console.WriteLine(name.ValidateLastName(LName));
        }
    }
}