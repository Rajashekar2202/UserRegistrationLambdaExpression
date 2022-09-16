namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Lambda Expression Problem");
            
            UserRegistration user = new UserRegistration();
            Console.WriteLine("****User Registration****");
            Console.WriteLine("Enter Firstname");
            string Firstname = Console.ReadLine();
            string opt = user.FirstnameCheckusingLambda(Firstname);

            if (opt == "FirstName is Valid")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(opt);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(opt);
                Console.ResetColor();
            }
        }
    }
}
