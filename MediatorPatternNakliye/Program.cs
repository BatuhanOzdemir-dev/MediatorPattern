using MediatorPatternNakliye.Concrete;
using MediatorPatternNakliye.Models;

namespace MediatorPatternNakliye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nakliye nakliye = new();

            XFirma xFirma = new(nakliye);
            YFirma yFirma = new(nakliye);

            nakliye.XFirma = xFirma;
            nakliye.YFirma = yFirma;

            nakliye.NakliyeyeBasla();
        }
    }
}