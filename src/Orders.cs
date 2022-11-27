using System;

namespace c{
    class Orders: Menu{

        public KeyValuePair<string, int> chosenMain { get; set; }
        public KeyValuePair<string, int> chosenSup { get; set; }
        public KeyValuePair<string, int> chosenDrink { get; set; }

        public KeyValuePair<string, int> randomMain(){
            Random random = new Random();
            Dictionary<string, int> randMain = this.createMain();
            KeyValuePair<string, int> randMainEntry = randMain.ElementAt(random.Next(0, randMain.Count));
            Console.WriteLine(randMainEntry);

            chosenMain = randMainEntry;

            return randMainEntry;
        } 

        public KeyValuePair<string, int> randomSup(){
            Random random = new Random();
            Dictionary<string, int> randSup = this.createSup();
            KeyValuePair<string, int> randSupEntry = randSup.ElementAt(random.Next(0, randSup.Count));
            Console.WriteLine(randSupEntry);

            chosenSup = randSupEntry;

            return randSupEntry;
        } 

        public KeyValuePair<string, int> randomDrink(){
            Random random = new Random();
            Dictionary<string, int> randDrink = this.createDrink();
            KeyValuePair<string, int> randDrinkEntry = randDrink.ElementAt(random.Next(0, randDrink.Count));
            Console.WriteLine(randDrinkEntry);

            chosenDrink = randDrinkEntry;

            return randDrinkEntry;
        }         
    }
}