using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP2
{
    public static class Order
    {
        //contains the name of teh user/customer
        public static string customer;
        //public static List<int> Ids = new List<int>();
        //variable which holds the value of current id
        public static int id = 0;
        public static string customerId; 
        //lists containing the string values of each ingredient, each cathegory has its own list
        public static List<string> Cheeses = new List<string>();
        public static List<string> Meat = new List<string>();
        public static List<string> Vegetables = new List<string>();
        //keys - contain string of each ingredient 
        //values - contain prices corespoding
        public static Dictionary<string, double> dictCheeses = new Dictionary<string, double>();
        public static Dictionary<string, double> dictMeat = new Dictionary<string, double>();
        public static Dictionary<string, double> dictVegetables = new Dictionary<string, double>();

        //loads strings of ingredients and their prices
        public static void intDictionaryValues()
        {
            //prices for cheeses
            if (dictCheeses.Count != 0)
                dictCheeses.Clear();
            if (dictCheeses.Count == 0)
            {
                dictCheeses.Add("Feta", 700);
                dictCheeses.Add("Parmesan", 300);
                dictCheeses.Add("Mozarella", 500);
                dictCheeses.Add("Dor Blue", 350);
                dictCheeses.Add("Edam", 400);
                dictCheeses.Add("Brinza", 200);
            }

            //prices for meat
            if (dictMeat.Count != 0)
                dictMeat.Clear();
            if (dictMeat.Count == 0)
            {
                dictMeat.Add("Bacon", 500);
                dictMeat.Add("Prosciutto", 1000);
                dictMeat.Add("Salami", 400);
                dictMeat.Add("Chicken Breast", 700);
                dictMeat.Add("Ham", 900);
            }

            //prices for vegetables
            if (dictVegetables.Count != 0)
                dictVegetables.Clear();
            if (dictVegetables.Count == 0)
            {
                dictVegetables.Add("Fresh Mushrooms", 500);
                dictVegetables.Add("Smoked Mushrooms", 700);
                dictVegetables.Add("Red Onion", 300);
                dictVegetables.Add("Tomatoes", 200);
                dictVegetables.Add("Garlic", 100);
                dictVegetables.Add("Rucola", 300);
                dictVegetables.Add("Marinated Gogoshars", 300);
                dictVegetables.Add("Corn", 400);
                dictVegetables.Add("Parsley", 300);
                dictVegetables.Add("Chili Pepper", 500);
            }
        }

        //computes prices for each type of ingredients
        public static double computePrice(Dictionary<string,double> dictionary, List<string> list)
        {
            double sum = 0;
            foreach (KeyValuePair<string, double> entry in dictionary)
            {
                foreach (string element in list)
                {
                    if (entry.Key == element)
                        sum += entry.Value;
                }
            }
            return sum;
        }

        //computes teh total price of the finally obtained pizza
        public static double totalPrice()
        {
            double totalSum = 0;
            totalSum += computePrice(dictCheeses, Cheeses);
            totalSum += computePrice(dictMeat, Meat);
            return totalSum += computePrice(dictVegetables, Vegetables);
        }

        //coputes the id of the current order
        public static string setID()
        {
            id++;
            if (id < 10)
            {
                return customerId = "0" + "0" + id.ToString();
            }
            else if (id < 100)
            {
                return customerId = "0" + id.ToString();
            }
            else 
            {
                return customerId = id.ToString();
            }
        }
    }
}
