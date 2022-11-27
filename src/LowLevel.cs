using System;

namespace c{
    abstract class LowLevel: Person{

        public int num_orders { get; set;}
        public int rating { get; set;}
        new public int grade { get; set;}
        public int salary { get; set;}
        public string status { get; set;}
        
        public Client client { get; set;}
        public Orders orders { get; set;}
       
        public LowLevel(Client client, Orders orders, string status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }

        public void qualityCheck(){
           
            Console.WriteLine("");
            Random rand = new Random();
            rating = rand.Next(1, 3);
            
            if (rating == 1){
                client.happiness--;
                Console.WriteLine(status + " did his work very bad!");
            }
            
            else if (rating == 2){
                client.happiness++;
                Console.WriteLine(status + " did his work really nice!");
            }
        }

        public virtual void speak(){
            Console.WriteLine("I am the " + status + " in this restaurant! ");
        }
    }
}