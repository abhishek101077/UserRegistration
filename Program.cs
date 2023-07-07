namespace Userregistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");
          // UC1 obj = new UC1();
          //   UC2 obj = new UC2();
             UC3 obj = new UC3();

            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(FName));
            Console.WriteLine("Enter the Last Name:");
            string LName = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(LName));
            Console.WriteLine(obj.ValidateFName(FName));
            Console.WriteLine(obj.ValidateFName(LName));
            Console.ReadLine();

        }
    }
}