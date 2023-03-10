
namespace VendingMachine
{
    public abstract class Ingredient
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public virtual void Add(Coffee coffee, int quantity)
        {
            coffee.Price += Price * quantity;
            if (coffee.Ingredients.ContainsKey(Name))
            {
                coffee.Ingredients[Name] += quantity;
            }
            else
            {
                coffee.Ingredients.Add(Name, quantity);
            }
        }
    }

    public class Milk : Ingredient
    {
        public Milk()
        {
            Name = "Milk";
            Price = 0.5;
        }
    }
    public class Sugar : Ingredient
    {
        public Sugar()
        {
            Name = "Sugar";
            Price = 0.2;
        }
    }

    public class Syrup : Ingredient
    {
        public Syrup()
        {
            Name = "Syrup";
            Price = 1.2;
        }
    }

    public class Cream : Ingredient
    {
        public Cream()
        {
            Name = "Cream";
            Price = 1.2;
        }
    }

    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {
            Name = "Cinnamon";
            Price = 1.6;
        }
    }

    public class Nutmeg : Ingredient
    {
        public Nutmeg()
        {
            Name = "Nutmeg";
            Price = 1.7;
        }
    }

    public class Caramel : Ingredient
    {
        public Caramel()
        {
            Name = "Caramel";
            Price = 1.9;
        }
    }
}
