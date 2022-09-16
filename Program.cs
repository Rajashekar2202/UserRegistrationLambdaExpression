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
            string Password2 = Console.ReadLine();
            string opt = user.validatePassword2usingLambda(Password2);
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
