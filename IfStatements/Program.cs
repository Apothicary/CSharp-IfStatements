namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // One example of an if and else if statement 

            if (age > 100) 
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >=18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18 to sign up!");
            }

            // Another example of an if statement

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name !="")
            {
                Console.WriteLine("Hello " + name);
            }    
            else
            {
                Console.WriteLine("You did not enter your name");
            }

            Console.ReadKey();
        }
    }
}
