using MediatorPatternNakliye.Abstraction;
using MediatorPatternNakliye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternNakliye.Concrete
{
    public class Nakliye : INakliye
    {
        XFirma _xFirma;
        YFirma _yFirma;

        public XFirma XFirma { set => _xFirma = value; }
        public YFirma YFirma { set => _yFirma = value; }

        public void NakliyeyeBasla()
        {
            _xFirma.NakliyeyeBasla();
        }

        public void MaliDevret(Firma firma)
        {
            if(firma is XFirma)
            {
                Console.WriteLine("Eşyalar Ankara'ya vardı.");
                _yFirma.NakliyeyeBasla();
            }
            else
            {
                Console.WriteLine("Eşyalar Bursa'ya vardı.");
            }
        }
    }
}
