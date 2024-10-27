namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            VendingMachine coffeeMacine = new VendingMachine("Кофемашина");
            coffeeMacine.AddCash(100);
            coffeeMacine.AddCash(150);
            coffeeMacine.ReturnCash();
            coffeeMacine.DrinkSelection("американо");
            coffeeMacine.DrinkSelection("капучино");
            coffeeMacine.DrinkSelection("латте");
            coffeeMacine.DrinkSelection("лрсиромрчсормравмавмора");
        }
    }
}
