using System.Reflection.PortableExecutable;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMacine = new CoffeeMachine("Кофемашина");

            SodaMacine sodaMacine = new SodaMacine("Автомат с газировкой");

            sodaMacine.DrinkSelection("кока кола");

            coffeeMacine.DrinkSelection("американо", "да");
            coffeeMacine.DrinkSelection("капучино", "да");
            coffeeMacine.PrintInfo();
            coffeeMacine.DrinkSelection("капучино", "да");
            coffeeMacine.PrintInfo();

            coffeeMacine.AddCash(50);
            coffeeMacine.ReturnCash();
            coffeeMacine.PrintInfo();
            coffeeMacine.ErrorNotification();
            coffeeMacine.Fix();
        }
    }
}
