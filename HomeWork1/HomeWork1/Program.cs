namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1.
            int age = 24;
            const string wellcomeMessage = "Wellcome to C#";

            Console.WriteLine(age);
            Console.WriteLine(wellcomeMessage);

            //Task2.
            Console.Write("Please enter your FullName: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int clientAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {fullName}. You are {clientAge} years old.");

            //Task3.
            Random random = new Random();
            int correctAnswer = random.Next(1, 10);
            int attempts = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}st Guess: Choose a number between 1 and 10: ");

                int clientGuess;
                while (!int.TryParse(Console.ReadLine(), out clientGuess))
                {
                    Console.Write("Invalid Input. Try again: ");
                }

                if (clientGuess == correctAnswer)
                {
                    Console.WriteLine("Congratulation!!! Your guess was CORRECT!!!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrect, {5 - i} attemps remaining.");
                }
                attempts++;
            }
            Console.WriteLine($"Correct number was: {correctAnswer}");

            //Task4.
            string secretCode = "C#";
            int attemps2 = 1;
            string codeGuess = "";

            while (codeGuess != secretCode)
            {
                Console.Write("Enter Your Guess: ");
                codeGuess = Console.ReadLine();

                if (codeGuess == secretCode)
                {
                    Console.WriteLine($"Congratulation!!! Your {attemps2}st guess was correct.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                    attemps2++;
                }
            }

            //Task5.
            int n;
            while (true)
            {
                Console.Write("Enter a positive integer: ");

                if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
                {
                    break;
                }

                Console.WriteLine("Invalid input! Please enter a number greater than 0.");
            }

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum of odd numbers between 1 and {n} is: {sum}");
        }
    }
}
