using MediatorPatternNakliye.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternNakliye.Models
{
    public class YFirma : Firma
    {
        public YFirma(INakliye nakliye) : base(nakliye)
        {
        }

        public override void NakliyeyeBasla()
        {
            Console.WriteLine("Ankara'dan eşyalar yüklendi.");
            _nakliye.MaliDevret(this);
        }
    }
}
