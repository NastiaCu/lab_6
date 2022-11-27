using System;

namespace c{
    interface IAdministrator{
       
        void Grade();
        void setStatus();
        void setRaiting(LowLevel lowlevel);
        void setTable(int NumOfClients);
        void whatSalary(LowLevel lowlevel, string status, int rating);
        void setGrade(int n);    
    }
}