using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendingMachine;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Coffee coffee = new Coffee();
            Milk milk = new Milk();
            coffee.ID = 1;
            coffee.Price = 1;
            coffee.Name = "Espresso";
            coffee.Ingredients = new Dictionary<string, int>();
            coffee.Ingredients.Add("Milk", 1);
            coffee.Ingredients.Add("Sugar", 1);
            coffee.AddIngredient(milk, 4);
            Assert.AreEqual(coffee.Price, 3);
            Assert.AreEqual(coffee.Ingredients["Milk"], 5);
        }

        [TestMethod]
        public void Test_LoadMenu()
        {
            LoadMenuJson menu = new LoadMenuJson();
            Assert.IsNotNull(menu.LoadMenu());
        }

        [TestMethod]
        public void Test_LoadIngredients()
        {
            Assert.IsNotNull(Ingredients.LoadAll());
        }
    }
}
