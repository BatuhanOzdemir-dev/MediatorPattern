using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternEmlak.Abstraction
{
    public interface IEmlakSatis
    {
        void OdemeYap(Kisi kisi, int tutar);
    }
}
