namespace factory
{

    class Program
    {
        static void Main(string[] args)
        {
            Creator []animals = new Creator[2];
            for (int i = 0; i <= animals.Length; i++){
                Console.WriteLine("Jméno:");
               string rasa =  Console.ReadLine();
               Console.WriteLine("Druh:");
               string druh = Console.ReadLine();
               Console.WriteLine("Věk:");
               int vek = Int32.Parse(Console.ReadLine());
               Console.WriteLine("Zvuk:");
               string zvuk = Console.ReadLine();
            }
            foreach (Creator animal in animals)
            {
                Creator zvire = animal.FactoryMethod();
                Console.WriteLine("${zvire.rasa},{zvire.vek}, {zvire.druh}");
            }
        }
    }
}