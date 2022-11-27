using System;
using System.Threading;


namespace c{

    class Administrator: HighLevel, IAdministrator{

        private Client client { get; set; }
        private Waiter waiter { get; set; }

        public int stars = 5;
        public int NumOfTables = 5;
        public int NumOfWaiters = 5;
        Random random = new Random();



        public Administrator(Waiter waiter, Client client): base(waiter, client){
            this.waiter = waiter;
            this.client = client;
        }
        
        public void Grade(){
            Console.WriteLine("");
            if (client.happiness <= 2){
                waiter.grade--;
                Console.WriteLine("The waiter now has a lower salary(");
            }
            else if (client.happiness > 2){
                waiter.grade++;
                Console.WriteLine("Good job!");
            }
        }

        public void setStatus(){
        
            if (client.happiness > 5){
                stars++;
            }
            else if (client.happiness <= 5){
                stars--;
            }

            Console.WriteLine("The rating of the restaurant is " + stars);
        }

        public override void whatSalary(LowLevel lowlevel, string status, int rating){
            base.whatSalary(lowlevel, status, rating);

            if (lowlevel.rating == 1){
                Console.WriteLine("This is your last warning.");
            }
            Console.WriteLine();

        }

        public void setRaiting(LowLevel lowlevel){
            lowlevel.rating = random.Next(1, 6);

            Console.WriteLine(lowlevel.status + " got rating: " + lowlevel.rating);
        }

        public void setTable(int NumOfClients){
            if (NumOfTables >= NumOfClients){
                Console.WriteLine("Admin: We have free space: " + (NumOfTables));
                this.setGrade(2);
                NumOfTables--;    
            }

            else if (NumOfTables < NumOfClients || NumOfTables == 0){
                Console.WriteLine("Admin: Sorry, we don't have free tables");
                this.setGrade(1);
                this.GoHome(NumOfClients);
            }

            freeTable(NumOfTables);

        }

        public void setWaiters(int NumOfClients){
            if (NumOfWaiters > NumOfClients/2){
                Console.WriteLine("Today the restaurant will earn a lot of money");
                this.setGrade(2);
            }

            else if (NumOfWaiters <= NumOfClients/2){
                Console.WriteLine("We don't have enought hands");
                this.setGrade(1);
                this.GoHome(NumOfClients);
            }
        }

        public void setGrade(int n){
            if (n == 1){
                stars --;
            }
            
            else if (n == 2){
                stars ++;
            }

            Console.WriteLine("The rating of the restaurant is " + stars);
        }

        public int GoHome(int NumOfClients){
            if (NumOfTables-NumOfClients < 0){
                return 0;
            }

            else if (NumOfWaiters <= NumOfClients/2){
                return 0;
            }
            
            else return 1;
        }

        public int freeTable(int NumOfTables){
            int n = random.Next(1, 3);

            if (n == 2){
            return NumOfTables+=1;
            }
            else 
                return NumOfTables;
        }

    }
}