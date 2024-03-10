
namespace _15_przeciazanie_metod
{
    internal class Kot
    {
        public void PokazInformacje(string imie)
        {
            Console.WriteLine($"imie: {imie}");
        }

        public void PokazInformacje(string imie, int wiek)
        {
            Console.WriteLine($"imie: {imie} \nwiek: {wiek}");
        }

        public void PokazInformacje(string imie, string kolorOczu)
        {
            Console.WriteLine($"imie: {imie} \nkolor oczu: {kolorOczu}");
        }

        public void PokazInformacje(string imie, string kolorOczu, string kolorSiersci)
        {
            Console.WriteLine($"imie: {imie} \nkolor oczu: {kolorOczu} \nkolor siersci: {kolorSiersci}");
        }
    }
}