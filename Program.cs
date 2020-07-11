using System;

namespace GuessingGame {
    class Program {
        static void Main(string[] args) {
            var r = new Random();
            int num = 0;
            int target = r.Next(10);
            Console.WriteLine("Pssst! its " + target);
            while (true) {
                Console.WriteLine("Guess a number:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == target) {
                    Console.WriteLine("You have it!");
                    break;
                }
                else if (num > target) {
                    Console.WriteLine("Try lower");
                }
                else if (num < target) {
                    Console.WriteLine("Try higher");
                }
            }
        }
    }
}
