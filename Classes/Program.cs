using System.Reflection.PortableExecutable;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine coffeeMacine = new VendingMachine("Кофемашина");
            VendingMachine sodaMachine = new VendingMachine("Автомат с газировкой");

            coffeeMacine.DrinkSelection("американо", "да");
            coffeeMacine.DrinkSelection("капучино", "да");
            coffeeMacine.AddCash(50);
            coffeeMacine.ReturnCash();
            coffeeMacine.PrintInfo();
            coffeeMacine.ErrorNotification();
        }
    }
}
