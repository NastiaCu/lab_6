using System;
using System.Collections.Generic;


namespace c{

    class Waiter: LowLevel{

        protected int Main { get; set; }
        protected int Sup { get; set; }
        protected int Drink { get; set; }
        public int ToPay { get; set; }
        
        private Orders orders { get; set; }
        private Client client { get; set; }
        new public string status { get; set; }
        
        new public int rating = 5;
        new public int salary = 4000;

        public Waiter(string status): base(status){
            this.status = status;
        }
        
        public override void speak(){
            base.speak();
            Console.WriteLine("What would you like to order?");
        }
        
        public int bill(Orders orders){

            KeyValuePair<string, int> MainDish = orders.chosenMain;
            KeyValuePair<string, int> Supplies = orders.chosenSup;
            KeyValuePair<string, int> DrinkM = orders.chosenDrink;

            Main = MainDish.Value;
            Sup = Supplies.Value;
            Drink = DrinkM.Value;
            ToPay = Main + Sup + Drink;
            Console.WriteLine("The total bill is " + ToPay);
            return ToPay;
        }
    }
}