namespace factory
{

    class Program {
        static void Main (string[]args){
            Auto Fabia = new Auto ("Škoda", "Fabia");
            var Felda = new TovarnaNaAuta();
            Console.WriteLine(Fabia.Vrrrrrrr());
        }
    }
    class Auto
    {
        private string znacka;
        private string model;
        public Auto(string znacka, string model)
        {
            this.znacka = znacka;
            this.model = model;
        }
        public string Vrrrrrrr(){
            return $"{znacka}, {model}";
        }
    }

    class TovarnaNaAuta
    {
        public Auto VytvorFelicii()
        {
            return new Auto("Škoda", "Felicia");
        }
    }
}

