using System;

namespace c{

    class Security: HighLevel{

        private Waiter waiter { get; set; }
        private Client client { get; set; }

        public Security(Waiter waiter, Client client): base(waiter, client){
            this.waiter = waiter;
            this.client = client;
        }

        public void goHome(Client client){
            if (client.happiness < -5){
                client.num--;
            }
            
            else if (client.happiness > 10){
                client.num--;
            }
        }

        public void washDishes(){
            if (client.money < 0){
                Console.WriteLine("Now the client has to wash the dishes ");
                client.happiness -= 5;
            }

            else if (client.money > 0){
                Console.WriteLine("Satisfied client goes home");
                client.happiness += 5;
            }
        }   
    }
}