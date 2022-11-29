using System;

namespace c{
    class Model: IModel{

        public int j = 5; 
        Menu menu = new Menu();
        private int NumOfClients { get; set; }
        private int NumOfDays { get; set; } = 0;
        private int NumOfTables { get; set; } = 5;
        private int stars { get; set; }
        

        Random rand = new Random();

        public int num { get; set; } = 0;
        public int Count { get; set; } = 0;

        public Waiter waiter = new Waiter("waiter");
        public Barman barman = new Barman("barman");
        public Chief chief = new Chief("chief");
        public IAdministrator administrator = new Administrator();
        public Security security = new Security();


        public int getClientsNum(){
            return NumOfClients;
        }

        public void setClientsNum(){
            this.NumOfClients = rand.Next(11);
        }

        public int getDaysNum(){
            return NumOfDays;
        }

        public void setDaysNum(int NumOfDays){
            this.NumOfDays = NumOfDays;
        }

        public int getStarsNum(){
            return num;
        }

        public void setStarsNum(int num){
            this.num = num;
        }

        public int getProfit(){
            return Count;
        }

        public void setProfit(int Count){
            this.Count = Count;
        }

        public void setVal(){
            
            List<Client> clients = new List<Client>();
            Orders orders = new Orders();
            Table table = new Table();

            for (int i = 0; i < NumOfClients; i++){
                clients.Add(new Client(orders));
            }

            for (int i = 0; i < clients.Count(); i++){
                Client client = clients[i];
                Console.WriteLine();
                Console.WriteLine("Client number: " + (i+1));

                table.setTable(client);
                
                table.table();

                administrator.setTable(NumOfTables, i);
                administrator.setWaiters(i);

                if (administrator.GoHome(NumOfTables, i) == 0){
                    break;
                }
                waiter.workExperienceCheck();
                chief.workExperienceCheck();
                barman.workExperienceCheck();

                waiter.speak();
                client.choose();
                
                barman.makeDrink(orders);
                barman.speak();
                barman.qualityCheck(client);
                    
                chief.cook(orders);
                chief.qualityCheck(client);
                chief.speak();
                    
                waiter.qualityCheck(client);
                waiter.bill(orders);

                administrator.Grade(client, waiter);

                Console.WriteLine("Client's happiness level: " + client.happiness);

                client.pay(waiter.ToPay);
                security.washDishes(client);

                administrator.setRaiting(waiter);
                administrator.setRaiting(chief);
                administrator.setRaiting(barman);

                administrator.whatSalary(waiter, "waiter",  waiter.rating);
                administrator.whatSalary(chief, "chief", chief.rating);
                administrator.whatSalary(barman, "barman", barman.rating);

                Console.WriteLine("");

                table.TableQuality();
                Console.WriteLine(table.quality);
                num = administrator.stars;
                Count += waiter.ToPay;
            }
        }
    }
}
