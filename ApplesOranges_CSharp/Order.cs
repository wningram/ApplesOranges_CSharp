using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplesOranges_CSharp {
    public class Order {
        public List<string> ParsedInput { get; set; }
        public const double APPLE_PRICE = 0.60;
        public const double ORANGE_PRICE = 0.25;

        public double CalculateGrossCost() {
            double totalCost = 0.0;

            foreach (string item in ParsedInput) {
                switch (item.ToLower()) {
                    case "orange":
                        totalCost += ORANGE_PRICE;
                        break;
                    case "apple":
                        totalCost += APPLE_PRICE;
                        break;
                }
            }

            return totalCost;
        }

        public double CalculateDiscount() {
            double discount = 0.0;
            int countApples = 0,
                countOranges = 0;

            countApples = ParsedInput.Count(item => item == "apple");
            countOranges = ParsedInput.Count(item => item == "orange");

            discount += countApples / 2 * APPLE_PRICE;
            discount += countOranges / 3 * ORANGE_PRICE;

            return discount * -1;
        }
    }
}
