namespace IP_Task_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());


            if (number1 % 3 == 0 && number1 % 5 == 0) //jest podzielna przez 3 i 5)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number1 % 3 == 0) // jest podzielne przez 3)
            {
                Console.WriteLine("Fizz");
            }
            else if (number1 % 5 == 0) //jest podzielne 5 )
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Oops, your number does not win anything :D");
            }
            
            Console.ReadLine();
        }
    }
}