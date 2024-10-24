﻿namespace Classes
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

        private double _americano;

        private double _cappuccino;

        private double _latte;

        public VendingMachine(string name, double cashBalance, double amountOfWater, double amountOfCoffee, double amountOfMilk, double amountOfSugar, double salesAmounts)
        {
            this.Name = name;
            this.CashBalance = cashBalance;
            this.AmountOfWater = amountOfWater;
            this.AmountOfCoffee = amountOfCoffee;
            this.AmountOfMilk = amountOfMilk;
            this.AmountOfSugar = amountOfSugar;
            this.SalesAmounts = salesAmounts;
            this._americano = 50;
            this._cappuccino = 100;
            this._latte = 200;

        }

    }
}
