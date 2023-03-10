using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : ICustomizedVendingMachine
    {
        private ILoadMenu _menuLoader;
        private List<Coffee> coffees;
        private Coffee selectedCoffee;

        public VendingMachine(ILoadMenu menuLoader)
        {
            this._menuLoader = menuLoader;
        }

        public void DisplayMenu()
        {
            coffees = _menuLoader.LoadMenu();
            foreach (var coffee in coffees)
            {
                Console.WriteLine(coffee.ToString());
            }
        }

        public void ChooseCoffee()
        {
            Console.WriteLine("Enter your selection: ");
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > coffees.Count)
            {
                Console.WriteLine("Please enter valid selection! Try again...");
            }
            selectedCoffee = coffees[selection - 1];
            Console.WriteLine("You choose " + selectedCoffee.ToString());
        }

        public void CustomizeCoffee()
        {
            Console.WriteLine("Would you like to customize? (1-yes/2-no): ");
            int customize;
            while (!int.TryParse(Console.ReadLine(), out customize) || customize < 1 || customize > 2)
            {
                Console.WriteLine("Please enter 1 or 2! Try again...");
            }
            if (customize == 1)
            {
                Console.WriteLine("Enter what you want to add (enter \"0\" to finish): ");
                Ingredients.DisplayAllIngredients();
                string selection = Console.ReadLine();
                int selectionID;
                var ingredients = Ingredients.LoadAll();
                while (!selection.Equals("0"))
                {
                    if (int.TryParse(selection, out selectionID) && selectionID > 0 && selectionID <= ingredients.Count)
                    {
                        Console.WriteLine("How much quantity you want to add?");
                        int quantity;
                        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1 || quantity > 5)
                        {
                            Console.WriteLine("Please enter a value greater than 0 and less than 5...");
                        }
                        selectedCoffee.AddIngredient(ingredients[selectionID - 1], quantity);
                        Console.WriteLine($"You added {quantity} {ingredients[selectionID - 1].Name}{(quantity > 1 ? "s" : "")}");
                        Console.WriteLine("Do you want to add something else? (enter some ingredient to proceed or '0' to finish)");
                    }
                    else
                    {
                        Console.WriteLine("Wrong selection! Try again...");
                    }
                    selection = Console.ReadLine();
                }
            }
            Success();
        }

        public void Success()
        {
            Console.WriteLine("You have successfully ordered a coffee!");
            Console.WriteLine(selectedCoffee.ToString());
        }

        public void Start()
        {
            DisplayMenu();
            ChooseCoffee();
            CustomizeCoffee();
        }
    }
}
