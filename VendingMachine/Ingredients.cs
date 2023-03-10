using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public static class Ingredients
    {
        public static List<Ingredient> LoadAll()
        {
            List<Ingredient> allIngredients = new List<Ingredient>();
            var types = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType == typeof(Ingredient));
            foreach (var type in types)
            {
                allIngredients.Add(Activator.CreateInstance(type) as Ingredient);
            }
            return allIngredients;
        }

        public static void DisplayAllIngredients()
        {
            var ingredients = LoadAll();
            int k = 1;
            string table = "\n" + Helper.PrintLine() + "\n";
            table += Helper.PrintRow("ID", "Name", "Price") + "\n"; ;
            table += Helper.PrintLine() + "\n"; ;
            foreach (var ingredient in ingredients)
            {
                table += Helper.PrintRow(k++.ToString(), ingredient.Name, ingredient.Price.ToString("$0.00")) + "\n";
            }
            table += Helper.PrintLine() + "\n"; ;
            Console.WriteLine(table);
        }
    }
}
