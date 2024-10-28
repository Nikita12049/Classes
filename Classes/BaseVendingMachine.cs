using System.Xml.Linq;

namespace Classes
{
    public class BaseVendingMachine
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
            double result = CashBalance;
            CashBalance = 0;
            Console.WriteLine($"Сдача = {result}");
            return result;
        }
    }
}
