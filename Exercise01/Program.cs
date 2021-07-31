using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The default regular expression checks for at least one digit.");
            displayUI();
            
        }

        static void displayUI(){
            Console.WriteLine("Enter a regular expression (or press Enter to use the default): ^[a-z]+$");
            var expression1 = Console.ReadLine();
            Console.WriteLine("Enter some input: ");
            var input1 = Console.ReadLine();
            if(expression1 == input1){
                Console.Write($"{Environment.NewLine}{expression1} matches {input1}.? True");
            } else{
                Console.Write($"{Environment.NewLine}{expression1} matches {input1}.? False");
                Console.Write($"{Environment.NewLine}Press Esc to end or any key to try again.");
              
            }
            Console.ReadKey(true);

        }
    }
}
