namespace stringManipulation
{
    public class Utils
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                Console.Write($"{prompt}: ");
                answer = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static void DefaultConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void InfoConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void ErrorConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void PrintErrorMessage(string message)
        {
            ErrorConsoleColor();
            Console.WriteLine(message);
            DefaultConsoleColor();
        }

        public static void PrintInfoMessage(string message)
        {
            InfoConsoleColor();
            Console.WriteLine(message);
            DefaultConsoleColor();
        }
    }
}
