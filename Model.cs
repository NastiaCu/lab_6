using System;

namespace c{
    class Model: IModel{

        public int j = 5; 
        Menu menu = new Menu();
        
        public void setVal(){
            Random rand = new Random();
            int NumOfClients = rand.Next(11);
            List<Client> clients = new List<Client>();
            Orders orders = new Orders();
            
            
            for (int i = 0; i < NumOfClients; i++){
                clients.Add(new Client(orders));
            }

            for (int i = 0; i < clients.Count(); i++){
                Client client = clients[i];
                Console.WriteLine();
                Console.WriteLine("Client number: " + (i+1));
                Table table = new Table(client);                
                Waiter waiter = new Waiter(client, orders, "waiter");
            }
        }
    }
}