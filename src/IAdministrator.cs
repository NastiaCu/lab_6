using System;

namespace c{
    interface IAdministrator{

        int stars { get; set; }
        int NumOfTables { get; set; }
        int NumOfWaiters { get; set; }
       
        void Grade(Client client, Waiter waiter);
        void setStatus(Client client);
        void setRaiting(LowLevel lowlevel);
        void setTable(int NumOfTables, int NumOfClients);
        void whatSalary(LowLevel lowlevel, string status, int rating);
       
        void setGrade(int n);    
        void setWaiters(int NumOfClients);
        
        int GoHome(int NumOfTables, int NumOfClients);
        int freeTable(int NumOfTables);
        int freeWaiter(int NumOfWaiters);
    }
}