using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuLoader = new LoadMenuJson();
            var vendingMachine = new VendingMachine(menuLoader);
            vendingMachine.Start();
        }
    }
}
