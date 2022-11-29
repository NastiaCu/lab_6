using System;

namespace c{

    class Controller{
        private View view { get; set; }
        private Model model { get; set; }
        Menu menu { get; set; }

        public Controller(View view, Model model){
            this.view = view;
            this.model = model;
        }

        public void getVal(Menu menu){
            this.menu = menu;
        }

        public void setClientsNum(){
            model.setClientsNum();
        }

        public int getClientsNum(){
            return model.getClientsNum();
        }

        public void setDaysNum(int NumOfDays){
            model.setDaysNum(NumOfDays);
        }

        public int getDaysNum(){
            return model.getDaysNum();
        }

        public void setStarsNum(int stars){
            model.setStarsNum(stars);
        }

        public int getStarsNum(){
            return model.getStarsNum();
        }

        public int getProfit(){
            return model.getProfit();
        }

        public void setProfit(int Count){
            model.setProfit(Count);
        }

        public void CreateMenu(Menu menu){
            this.getVal(menu);
            menu.createMain();
            menu.createSup();
            menu.createDrink();
        }

        public void updateView(){
            view.PrintStatistics(model.getClientsNum(), model.getDaysNum());
        }

        public void updateViewFinal(){
            view.PrintAllStatistics(model.getClientsNum(), model.getDaysNum(), model.getStarsNum(), model.getProfit());
        }
    }
}