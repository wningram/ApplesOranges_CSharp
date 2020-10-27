using System;
using System.Collections.Generic;

namespace ApplesOranges_CSharp {
    class Program {

        private static void validateInput(List<string> parsedData) {
            foreach (string item in parsedData) {
                 switch(item.ToLower()) {
                    case "orange":
                    case "apple":
                        break;
                    default:
                        throw new Exception("Invalid Input");
                }
            }
        }

        private static List<string>  parseInput(string input) {
            if (input != null) {
                List<string> parsedData = input.Replace(' ', '').Split('.');
                validateInput(parsedData);
                return parsedData;
            } else {
                return new List<string>();
            }
        }

        static void Main(string[] args) {
            bool run = true;
            string helpText = "Enter a comma separated list of items to order. Valid inputs are: Apple or Orange." +
                "Enter restock apples/oranges ENTER, then enter the number of items to restock.";

            while (run) {
                Console.Write("Input -> ");
                string input = Console.ReadLine();
                
                switch (input.ToLower()) {
                    case "quit":
                        run = false;
                        break;
                    case "help":
                        break;
                    default:
                        
                        break;
                }
            }

            Console.WriteLine("Program successfully terminated.");
        }
    }
}
