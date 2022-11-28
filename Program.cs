using System;
using System.Threading;


namespace c{
    
    class Program{

        static void Main(){
            
            Menu menu = new Menu();
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(view, model);

            controller.CreateMenu(menu);
            view.DisplayMenu(menu);

            int i = 1;
            model.num = 0;
            model.Count = 0;

            while (true){

                model.num = 0;
                model.Count = 0;
                
                controller.setClientsNum();
                controller.setDaysNum(i);
                
                controller.updateView();
                model.setVal();
                Console.WriteLine();
                controller.updateViewFinal();
                i++;

                TimeSpan timeout = new TimeSpan(0, 0, 3);
                Thread.Sleep(timeout);
                }
            }
        }
    }

