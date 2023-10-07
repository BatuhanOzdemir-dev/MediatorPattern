using MediatorPatternEmlak.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternEmlak.Models
{
    public class Satici : Kisi
    {
        public Satici(IEmlakSatis emlakSatis) : base(emlakSatis)
        {
        }

        public void OdemeAl(int tutar)
        {
            Console.WriteLine($"Satıcı {tutar}₺ ödeme almıştır.");
            emlakSatis.OdemeYap(this, tutar);
        }
    }
}
