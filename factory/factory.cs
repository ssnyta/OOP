using System.Configuration.Assemblies;

namespace factory
{
    abstract class Creator
    {
        public abstract Animal FactoryMethod();
    }
    class Animal : Creator{
        public override Animal FactoryMethod()
        {
            return new Animal(this.race,this.type,this.age, this.noise);
        }
        private string race;
        private string type;
        private int age;
        private string noise;
        public Animal(string race, string type, int age, string noise)
        {
            this.race = race;
            this.type = type;
            this.age = age;
            this.noise =  noise;
        }
        public string MakeSomeNoise (){
           return "${this.noise}";
        }
    }
}

