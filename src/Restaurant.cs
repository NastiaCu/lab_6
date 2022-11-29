using System;

namespace c{

    class Restaurant{

        public string name { get; set; }

        public string adress { get; set; }

        public void setValues(string name, string adress){
            this.name = name;
            this.adress = adress;
        }

        public void printValues(){
            System.Console.WriteLine("Name of the restaurant: " + name );
            System.Console.WriteLine("Adress of the restaurants: " + adress);
        }
    }
}