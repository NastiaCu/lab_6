using System;

namespace c{

    interface IModel{
        int getClientsNum();
        int getDaysNum();
        int getStarsNum();
        int getProfit();

        void setClientsNum();
        void setDaysNum(int NumOfDays);
        void setStarsNum(int stars);
        void setProfit(int Count);

        

        void setVal();
    }
}