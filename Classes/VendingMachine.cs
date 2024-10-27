namespace Classes
{
    public class VendingMachine
    {
        public string Name { get; private set; }
        public double CashBalance { get; private set; }
        public double AmountOfWater { get; private set; }
        public double AmountOfCoffee { get; private set; }
        public double AmountOfMilk { get; private set; }
        public double AmountOfSugar { get; private set; }
        public double SalesAmounts { get; private set; }

        private int _priceOfAmericano;

        private int _priceOfCappuccino;

        private int _priceOfLatte;

        public VendingMachine(string name)
        {
            this.Name = name;
            this.CashBalance = 0;
            this.SalesAmounts = 0;
            this._priceOfAmericano = 50;
            this._priceOfCappuccino = 100;
            this._priceOfLatte = 200;
            Fix();
        }

        public void AddCash(double amountOfMoney)
        {
            CashBalance += amountOfMoney;
            Console.WriteLine($"В авмтомат {Name} положили {amountOfMoney}. баланс = {CashBalance}");
        }

        public double ReturnCash()
        {
            double result = CashBalance;
            CashBalance = 0;
            Console.WriteLine($"Сдача = {result}");
            return result;
        }

        public double DrinkSelection(string choice)
        {
            if (choice == "американо")
            {
                SalesAmounts += _priceOfAmericano;
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfAmericano}");
            }
            else if (choice == "капучино")
            {
                SalesAmounts += _priceOfCappuccino;
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfCappuccino}");
            }
            else if (choice == "латте")
            {
                SalesAmounts += _priceOfLatte;
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfLatte}");
            }
            else
            {
                Console.WriteLine("Такого напитка нет");
            }
            return SalesAmounts;
        }

        public void Fix()
        {
            this.AmountOfWater = 2;
            this.AmountOfCoffee = 250;
            this.AmountOfMilk = 1;
            this.AmountOfSugar = 150;
        }

    }
}