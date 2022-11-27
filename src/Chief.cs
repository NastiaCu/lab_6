using System;

namespace c{

    class Chief: LowLevel{
        private string main { get; set; }
        private string supplies { get; set; }
       
        new private Orders orders { get; set; }
        new private Client client { get; set; }
        
        new public string status { get; set; }
        new public int rating = 5;
        new protected int salary = 5000;


        public Chief(Client client, Orders orders, string status): base(client, orders, status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }

        public void cook(){

            KeyValuePair<string, int> chiefCookedMain = orders.chosenMain;
            KeyValuePair<string, int> chiefCookedSup = orders.chosenSup;

            Console.WriteLine("");

            Console.WriteLine("Chief cooked ");
            Console.WriteLine(chiefCookedMain);
            Console.WriteLine(chiefCookedSup);

        }

        public override void speak(){
            base.speak();
            
            if (this.rating == 1){
            Console.WriteLine("I've got more Michelin stars than the years you've lived on earth, so eat and don't show off");
            }

            if (this.rating == 2){
                Console.WriteLine("Enjoy your meal!");
            }

        }
    }
}