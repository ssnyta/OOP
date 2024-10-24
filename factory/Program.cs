using System.Configuration.Assemblies;

namespace factory
{

    class Program {
        static void Main (string[]args){
            
        }
    }

    
    class Animal
    {
        private string race;
        private string type;
        private int age;
        public Animal(string race, string type, int age)
        {
            this.race = race;
            this.type = type;
            this.age = age;
        }
        public string MakeSomeNoise (){
           
        }
    }
}

