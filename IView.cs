using System;

namespace c{

    interface IView{
        void getVal(Menu menu);
        void DisplayMenu(Menu menu);
        void PrintStatistics(int NumOfClients, int NumOfDays);
        void PrintAllStatistics(int NumOfClients, int NumOfDays, int stars, int profit);
    }
}