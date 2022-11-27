using System;
using System.Collections.Generic;
using System.Linq;

namespace c{

    class Menu: IMenu{
        
        public Dictionary<string, int> Main_menu { get; set; }
        public Dictionary<string, int> Sup_menu { get; set; }
        public Dictionary<string, int> Drink_menu { get; set; }
        

        public Dictionary<string, int> createMain(){
            Dictionary<string, int> Main_menu = new Dictionary<string, int>(){
                                                                                {"chicken", 90},
                                                                                {"steak", 180},
                                                                                {"burger", 85},
                                                                                {"pizza", 140}};  
            return Main_menu;
            }   

        public void dispMain(){

            Dictionary<string, int> Main_menu = new Dictionary<string, int>(){
                                                                                {"chicken", 90},
                                                                                {"steak", 180},
                                                                                {"burger", 85},
                                                                                {"pizza", 140}};

            Console.WriteLine();
            Console.WriteLine("Main menu:");
            Console.WriteLine();
            
            foreach(KeyValuePair<string, int> el in Main_menu){                
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }

        }

        public Dictionary<string, int> createSup(){
            Dictionary<string, int> Sup_menu = new Dictionary<string, int>(){
                                                                                {"fries", 50},
                                                                                {"placinte cu visina", 40},
                                                                                {"salad", 60},
                                                                                {"bread", 10}};  
            return Sup_menu;
        }

        public void dispSup(){
            Dictionary<string, int> Sup_menu = new Dictionary<string, int>(){
                                                                                {"fries", 50},
                                                                                {"placinte cu visina", 40},
                                                                                {"salad", 60},
                                                                                {"bread", 10}};  

            Console.WriteLine();
            Console.WriteLine("Supplies menu:");
            Console.WriteLine();
            
            foreach(KeyValuePair<string, int> el in Sup_menu){                
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }

        }

        public Dictionary<string, int> createDrink(){
            Dictionary<string, int> Drink_menu = new Dictionary<string, int>(){
                                                                                {"coca-cola", 25},
                                                                                {"orange juice", 50},
                                                                                {"beer", 50},
                                                                                {"lemonade", 50}};  
            return Drink_menu;
        }

        public void dispDrink(){

            Dictionary<string, int> Drink_menu = new Dictionary<string, int>(){
                                                                                {"coca-cola", 25},
                                                                                {"orange juice", 50},
                                                                                {"beer", 50},
                                                                                {"lemonade", 50}};

            Console.WriteLine();
            Console.WriteLine("Drink menu:");
            Console.WriteLine();
            
            foreach(KeyValuePair<string, int> el in Drink_menu){
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }
            
            Console.WriteLine();

        }
    }   
}