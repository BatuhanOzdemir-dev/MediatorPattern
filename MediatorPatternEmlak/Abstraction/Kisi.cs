using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternEmlak.Abstraction
{
    public abstract class Kisi
    {
        protected IEmlakSatis emlakSatis;
        protected Kisi(IEmlakSatis emlakSatis)
        {
            this.emlakSatis = emlakSatis;
        }
    }
}
