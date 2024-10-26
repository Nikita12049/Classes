namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            VendingMachine coffeeMacine = new VendingMachine("Кофемашина");
            coffeeMacine.AddCash(100);
            coffeeMacine.AddCash(150);
            coffeeMacine.ReturneCash();

        }
    }
}
