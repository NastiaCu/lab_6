using System;

namespace c{
    class View: IView{

        Menu menu;
       
        public void getVal(Menu menu){
            this.menu = menu;
        }

        public void DisplayMenu(Menu menu){
            this.getVal(menu);
            menu.dispMain();
            menu.dispSup();
            menu.dispDrink();
        }

        public void PrintStatistics(int NumOfClients, int NumOfDays){
            Console.WriteLine("#########################");
            Console.WriteLine("Number of clients: " + NumOfClients);
            Console.WriteLine("In day: " + NumOfDays);
            Console.WriteLine("#########################");
        }

        public void PrintAllStatistics(int NumOfClients, int NumOfDays, int stars, int profit){
            Console.WriteLine("#########################");
            Console.WriteLine("Number of clients: " + NumOfClients);
            Console.WriteLine("In day: " + NumOfDays);
            Console.WriteLine("Number of stars: " + stars);
            Console.WriteLine("Total profit: " + profit);
            Console.WriteLine("#########################");
        }

    }
}