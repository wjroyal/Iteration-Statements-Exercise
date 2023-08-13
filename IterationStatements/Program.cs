using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {


        
        static void Main(string[] args)
        {
            PrintThousand();

            PauseConsole();

            PrintByThrees();

            PauseConsole();

            int userNumber1 = GetUserNumber1();
            int userNumber2 = GetUserNumber2();

            bool areEqual = IsEqual(userNumber1, userNumber2);
            Console.WriteLine($"{userNumber1} is equal to {userNumber2}: {areEqual}");

            PauseConsole();

            int singleNumber = SingleNumber();  
            EvenOrOdd(singleNumber);

            PauseConsole();

            singleNumber = SingleNumber();
            PosNeg(singleNumber);

            PauseConsole();

            int age;
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Could not compute, try again");
            }
            CanVote(age);

            PauseConsole();

            int userNumber = GetUserNumber1();

            RangeChecker(userNumber);

            PauseConsole();

            userNumber = GetUserNumber1();

            MultiTable(userNumber);


            




        }

        private static int SingleNumber()
        {
            Console.WriteLine("Give me a number");
            int singleNumber = int.Parse(Console.ReadLine());
            return singleNumber;
        }

        private static int GetUserNumber2()
        {
            Console.Write("Give me a number: ");
            int userNumber2 = int.Parse(Console.ReadLine());
            return userNumber2;
        }

        private static int GetUserNumber1()
        {
            Console.Write("Give me a number: ");
            int userNumber1 = int.Parse(Console.ReadLine());
            return userNumber1;
        }

       
        

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000 && i <= 1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThrees()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        private static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        private static bool IsEqual(int num1, int num2)
        {

            return num1 == num2;

        }

        //Write a method to check whether a given number is even or odd
        private static void EvenOrOdd(int singleNumber)
        {
            if (singleNumber % 2 == 0)
            {
                Console.WriteLine($"{singleNumber} is even!");
            }

            else if (singleNumber % 2 != 0)
            {
                Console.WriteLine($"{singleNumber} is odd!");
            }

            else
            {
                Console.WriteLine("I have no clue what that is");
            }
        }

        //Write a method to check whether a given number is positive or negative
        private static void PosNeg(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine($"{num1} is positive");
            }
            else if (num1 < 0)
            {
                Console.WriteLine($"{num1} is negative");
            }
            else
            {
                Console.WriteLine($"{num1} is zero");
            }
            
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        private static void CanVote(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("You may vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote!");
            }
        }











        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

       private static void RangeChecker(int userNumber1)
        {
            if (userNumber1 >= 10 && userNumber1 <= 10)
            {
                Console.WriteLine($"{userNumber1} is in range");
            }
            else
            {
                Console.WriteLine("Out of range");

            }
        }
        




        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        private static void MultiTable(int userNumber)
        {

            int product = 0;
            for (int i = 0; i <= 12; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} * {i} = {product}");
            }
        }




    }
}
