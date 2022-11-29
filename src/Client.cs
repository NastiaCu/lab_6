using System; 

namespace c{

    class Client{

        private Orders orders;
        
        public int money { get; set;} = 200;
        public int happiness { get; set;} = 2;
        public int num { get; set;}
        

        public Client(Orders orders){
            this.orders = orders;
        }


        public void pay(int bill){
            money -= bill;
            Console.WriteLine("remained cash " + money + "$");
        }

        public void choose(){
            Console.WriteLine("");
            Console.WriteLine("The client chose: ");
            orders.randomMain();
            orders.randomSup();
            orders.randomDrink();
           
        }

    }
}