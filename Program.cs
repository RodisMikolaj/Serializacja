using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.Imie = "Mikołaj";
            osoba1.Nazwisko = "Sidor";
            osoba1.Wiek = 21;
            osoba1.Save("DaneOsobowe.xml");
            Osoba wczytaj = Osoba.Load("DaneOsobowe.xml");
        }
    }
}