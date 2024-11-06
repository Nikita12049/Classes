namespace Classes
{
    public class CoffeeMachine : BaseVendingMachine
    {
        public double AmountOfWater { get; private set; }
        public double AmountOfCoffee { get; private set; }
        public double AmountOfMilk { get; private set; }
        public double AmountOfSugar { get; private set; }

        private int _priceOfAmericano;

        private int _priceOfCappuccino;

        private int _priceOfLatte;

        public CoffeeMachine(string name) : base(name)
        {
            this._priceOfAmericano = 50;
            this._priceOfCappuccino = 100;
            this._priceOfLatte = 200;
            Fix();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Количество воды: {AmountOfWater}. Количество кофе: {AmountOfCoffee}. Количество молока: {AmountOfMilk}. Количество сахара {AmountOfSugar}.");
        }

        public override double DrinkSelection(string choice, string addSugar)
        {
            if (choice == "американо")
            {
                CashBalance -= _priceOfAmericano;
                SalesAmounts += _priceOfAmericano;
                AmountOfWater -= 0.15;
                AmountOfCoffee -= 10;

                if (addSugar == "да")
                {
                    AmountOfSugar -= 5;
                }
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfAmericano}");
            }
            else if (choice == "капучино")
            {
                CashBalance -= _priceOfCappuccino;
                SalesAmounts += _priceOfCappuccino;
                AmountOfWater -= 0.03;
                AmountOfCoffee -= 10;
                AmountOfMilk -= 0.1;

                if (addSugar == "да")
                {
                    AmountOfSugar -= 5;
                }
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfCappuccino}");
            }

            else if (choice == "латте")
            {

                CashBalance -= _priceOfLatte;
                SalesAmounts += _priceOfLatte;
                AmountOfWater -= 0.03;
                AmountOfCoffee -= 10;
                AmountOfMilk += 0.2;

                if (addSugar == "да")
                {
                    AmountOfSugar -= 5;
                }
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfLatte}");
            }

            else
            {
                Console.WriteLine("Такого напитка нет");
            }
            Console.WriteLine($"Сумма продаж = {SalesAmounts}");

            ErrorNotification();
            Fix();

            return SalesAmounts;
        }

        public void ErrorNotification()
        {
            if (AmountOfWater <= 0)
            {
                Console.WriteLine("В кофемашине закончилась вода приходите позже");
            }

            if (AmountOfCoffee <= 0)
            {
                Console.WriteLine("В кофемашине закончился кофе приходите позже");
            }

            if (AmountOfMilk <= 0)
            {
                Console.WriteLine("В кофемашине закончилось молоко приходите позже");
            }

            if (AmountOfSugar <= 0)
            {
                Console.WriteLine("В кофемашине закончился сахар приходите позже");
            }

            else
            {
                Console.WriteLine("Ошибок не обнаружено");
            }
        }

        public void Fix()
        {
            if (AmountOfWater <= 0)
            {
                this.AmountOfWater = 2;
            }

            if (AmountOfCoffee <= 0)
            {
                this.AmountOfCoffee = 250;
            }

            if (AmountOfMilk <= 0)
            {
                this.AmountOfMilk = 1;
            }

            if (AmountOfSugar <= 0)
            {
                this.AmountOfSugar = 150;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is CoffeeMachine machine &&
                   Name == machine.Name &&
                   CashBalance == machine.CashBalance &&
                   SalesAmounts == machine.SalesAmounts &&
                   AmountOfWater == machine.AmountOfWater &&
                   AmountOfCoffee == machine.AmountOfCoffee &&
                   AmountOfMilk == machine.AmountOfMilk &&
                   AmountOfSugar == machine.AmountOfSugar &&
                   _priceOfAmericano == machine._priceOfAmericano &&
                   _priceOfCappuccino == machine._priceOfCappuccino &&
                   _priceOfLatte == machine._priceOfLatte;
        }
    }
}