using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternNakliye.Abstraction
{
    public interface INakliye
    {
        void MaliDevret(Firma firma);
    }
}
