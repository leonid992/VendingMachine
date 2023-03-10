using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IVendingMachine
    {
        void CustomizeCoffee();
    }

    public interface IVendingMachineBasic
    {
        void DisplayMenu();
        void Start();
        void ChooseCoffee();
        void Success();
    }

    public interface ICustomizedVendingMachine : IVendingMachineBasic, IVendingMachine { }
}
