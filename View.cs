using System;

namespace c{
    class View: IView{

        Menu menu;
        public void DisplayInfo(Controller controller){
            Console.WriteLine(controller.Increase());
        }

        public void getVal(Menu menu){
            this.menu = menu;
        }

        public void DisplayMenu(Menu menu){
            this.getVal(menu);
            menu.dispMain();
            menu.dispSup();
            menu.dispDrink();
        }

    }
}