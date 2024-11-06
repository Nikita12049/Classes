namespace Classes
{
    abstract class BaseVendingMachine
    {
        public string Name { get; private set; }
        public double CashBalance { get; set; }
        public double SalesAmounts { get; set; }

        public BaseVendingMachine(string name)
        {
            this.Name = name;
            this.CashBalance = 0;
            this.SalesAmounts = 0;
        }

        public void AddCash(double amountOfMoney)
        {
            CashBalance += amountOfMoney;
            Console.WriteLine($"В авмтомат {Name} положили {amountOfMoney}. баланс = {CashBalance}");
        }

        public double ReturnCash()
        {
            double HandingOverMoney = 0;

            if (CashBalance <= 0)
            {
                Console.WriteLine("Недостаточно средств");
            }

            if (CashBalance > 0)
            {

            }

            Console.WriteLine($"Сдача = {HandingOverMoney}");
            return HandingOverMoney;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseVendingMachine machine &&
                   Name == machine.Name &&
                   CashBalance == machine.CashBalance &&
                   SalesAmounts == machine.SalesAmounts;
        }
    }
}
