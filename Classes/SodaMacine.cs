namespace Classes
{
    public class SodaMacine : BaseVendingMachine
    {

        private int _priceOfСocaСola;

        private int _priceOfSprite;

        private int _priceOfFanta;

        public SodaMacine(string name) : base(name)
        {
            this._priceOfСocaСola = 200;
            this._priceOfSprite = 100;
            this._priceOfFanta = 50;
        }

        public double DrinkSelection(string choice)
        {
            if (choice == "кока кола")
            {
                SalesAmounts += _priceOfСocaСola;

                Console.WriteLine($"К сумме продаж прибавилось {_priceOfСocaСola}");
            }

            else if (choice == "спрайт")
            {
                SalesAmounts += _priceOfSprite;
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfSprite}");
            }
            

            else if (choice == "фанта")
            {
                SalesAmounts += _priceOfFanta;
                Console.WriteLine($"К сумме продаж прибавилось {_priceOfFanta}");
            }

            else
            {
                Console.WriteLine("Такого напитка нет");
            }
            Console.WriteLine($"Сумма продаж = {SalesAmounts}");

            return SalesAmounts;
        }
    }
}
