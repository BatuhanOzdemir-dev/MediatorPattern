using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternNakliye.Abstraction
{
    public abstract class Firma
    {
        protected INakliye _nakliye;

        protected Firma(INakliye nakliye)
        {
            _nakliye = nakliye;
        }

        public abstract void NakliyeyeBasla();
    }
}
