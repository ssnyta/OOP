class Auto
{
    private string znacka;
    private string model;
    public Auto(string znacka, string model)
    {
        this.znacka = znacka;
        this.model = model;
    }
}

class TovarnaNaAuta
{
    public Auto VytvorFelicii()
    {
        return new Auto("Škoda", "Felicia");
    }
}