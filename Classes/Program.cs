namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.name = "Кофемашина";
            vendingMachine.cashBalance = 0;
            vendingMachine.amountOfWater = 2; //литра
            vendingMachine.amountOfCoffee = 250; //грамм
            vendingMachine.amountOfMilk = 1; //литр
            vendingMachine.amountOfSugar = 150; //грамм
            vendingMachine.salesAmounts = 0;
        }
    }
}
