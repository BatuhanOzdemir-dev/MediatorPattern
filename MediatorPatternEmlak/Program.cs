using MediatorPatternEmlak.Concrete;
using MediatorPatternEmlak.Models;

namespace MediatorPatternEmlak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konut bedeli 100k'nın üstündeyse satıcı emlakçıya %3 komisyon öder.
            //Konut bedeli 100k'nın altındaysa alıcı emlakçıya %10 komisyon öder.

            EmlakSatis emlakSatis = new();

            Alici alici = new(emlakSatis);
            Satici satici = new(emlakSatis);
            Emlakci emlakci = new(emlakSatis);

            emlakSatis.Alici = alici;
            emlakSatis.Satici = satici;
            emlakSatis.Emlakci = emlakci;

            alici.OdemeYap(200000);
            Console.WriteLine("***********");
            alici.OdemeYap(100000);
        }
    }
}