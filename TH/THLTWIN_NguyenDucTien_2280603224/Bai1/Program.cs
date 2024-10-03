using System;

namespace bai1

{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("=== Chuong trinh doan so ===");
            Random random = new Random();
            int targetNumber = random.Next(100, 999); 
            string targetString = targetNumber.ToString();
            int attempt = 1, MAX_GUESS = 7;
            string guess = "", feedback = "";

            while (feedback != "+++" && attempt <= MAX_GUESS)
            {
                Console.WriteLine("Lan doan thu {0}: ", attempt);
                guess = Console.ReadLine();

                if (guess.Length != 3)
                {
                    Console.WriteLine("Vui long nhap mot so co 3 chu so!");
                    continue;
                }

                feedback = GetFeedback(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                attempt++;
            }


            if (feedback == "+++")
            {
                Console.WriteLine("Chuc mung! Ban da doan dung so.");
            }
            else
            {
                Console.WriteLine("Nguoi choi da het luot doan. So dung la: {0}", targetString);
            }

            Console.ReadLine(); 
        }

        static string GetFeedback(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                {
                    feedback += "+";
                }
                else if (target.Contains(guess[i].ToString()))
                {
                    feedback += "?";
                }
                else
                {
                    feedback += "_";
                }
            }
            return feedback;
        }
    }
}
