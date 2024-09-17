﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static string GetFeedback(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (guess[i] == target[i])
                {
                    feedback += "+";
                }
                else if (target.Contains(guess[i].ToString()))
                {
                    feedback += "?";
                }
            }
            return feedback;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int targetNumber = rnd.Next(100, 999);
            string targetString = targetNumber.ToString();
            int attempt = 1, MAX_GUESS = 7;
            string guess = "", feedback = "";
            while (feedback != "+++" && attempt <= MAX_GUESS) { 
                Console.WriteLine("Lan doan thu {0}: ", attempt);
                guess = Console.ReadLine();
                feedback = GetFeedback(targetString, guess);
                Console.WriteLine("Phan hoi tu may: {0}", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. Tro choi ket thuc!", attempt - 1);
            if (attempt > MAX_GUESS)
            {
                Console.WriteLine("Nguoi choi da thua cuoc so can doan la {0}", targetNumber);
            }
            else
            {
                Console.WriteLine("Nguoi choi thang cuoc!", attempt);
            }
            Console.ReadLine();
        }
    }
}
