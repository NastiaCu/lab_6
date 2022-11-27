using System;

namespace c{
    abstract class Person: Restaurant{

        public int workExperience { get; set; }
        public int grade { get; set; }
        

        public void workExperienceCheck(){

            Random rand = new Random();
            workExperience = rand.Next(1, 6);

            if (workExperience <= 2){
                grade = rand.Next(1, 3);
            }
            else if (workExperience > 2){
                grade = rand.Next(3, 6);
            }
        }
    }
}