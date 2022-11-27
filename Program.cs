using System;
using System.Threading;


namespace c{
    
    class Program{

        static void Main(){
            
            Menu menu = new Menu();
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(view, model);

            view.DisplayInfo(controller);
            controller.CreateMenu(menu);
            view.DisplayMenu(menu);
            }
        }
    }

