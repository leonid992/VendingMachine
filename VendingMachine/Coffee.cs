using System.Collections.Generic;

namespace VendingMachine
{
    public class Coffee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }

        public override string ToString()
        {
            return $"ID:{ID} {Name} {Price:$0.00} {Helper.DisplayIngredients(this)} ";
        }

        public void AddIngredient(Ingredient ingredient, int quantity)
        {
            ingredient.Add(this, quantity);
        }
    }
}
