using System;

namespace c{

    class Barman: LowLevel{
        private int num_drinks { get; set; }
        private Orders orders { get; set; }
        private Client client { get; set; }
        new public string status { get; set; }
        new public int rating = 5;
        new public int salary = 4000;

        public Barman(string status): base(status){
            this.status = status;
        }

        public override void speak(){
            base.speak();
            Console.WriteLine("ОФИЦИАНТ!!!!!!!!!");
        }

        public void makeDrink(Orders orders){
            KeyValuePair<string, int> BarmanServed = orders.chosenDrink;

            Console.WriteLine("");
            Console.WriteLine("Barman serverd: ");
            Console.WriteLine(BarmanServed);
            num_drinks++;

        }
    }
}