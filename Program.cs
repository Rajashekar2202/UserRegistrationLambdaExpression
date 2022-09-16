namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Lambda Expression Problem");
            
            UserRegistration user = new UserRegistration();
            Console.WriteLine("****User Registration****");
            Console.WriteLine("Enter Password");
            string Email9 = Console.ReadLine();
            string opt = user.validateEmail9usingLambda(Email9);
            if (opt == "Valid")
            {
                Console.WriteLine("Pattern is matched");
            }
            else
            {
                Console.WriteLine("Pattern is not matched");
            }
        }
    }
}
