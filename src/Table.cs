using System;

namespace c{
    class Table: ITable{
        public int quality { get; set; }
        private Client client { get; set; }

        public Table(Client client){
            this.client = client;  
        }

        public int table(){
            Random rand = new Random();
            this.quality = rand.Next(1, 6);
            return  this.quality;
        }

        public void TableQuality(){
            if (this.quality == 0){
                client.happiness -= 3;
                Console.WriteLine("Client is going to kill someone!");
            }

            else if (quality == 1){
                client.happiness -= 2;
                Console.WriteLine("Client is really angry");
            }

            else if (quality == 2){
                client.happiness -= 1;
                Console.WriteLine("Client is mad");
            }

            else if (quality == 3){
                client.happiness += 1;
                Console.WriteLine("Client is chill");
            }

            if (quality == 4){
                client.happiness += 2;
                Console.WriteLine("Client is satisfied");
            }

            if (quality == 5){
                client.happiness += 3;
                Console.WriteLine("Client is really happy!");
            }
        }
    }
}