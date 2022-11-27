using System;

namespace c{

    class Controller{
        private View view;
        private Model model;
        Menu menu;

        public Controller(View view, Model model){
            
            this.view = view;
            this.model = model;
        }

        public int Increase(){
            return model.j+=4;
        }

        public void getVal(Menu menu){
            this.menu = menu;
        }

        public void CreateMenu(Menu menu){
            this.getVal(menu);
            menu.createMain();
            menu.createSup();
            menu.createDrink();

        }
    }
}