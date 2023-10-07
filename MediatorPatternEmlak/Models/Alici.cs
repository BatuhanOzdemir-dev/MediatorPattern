using MediatorPatternEmlak.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternEmlak.Models
{
    public class Alici : Kisi
    {
        public Alici(IEmlakSatis emlakSatis) : base(emlakSatis)
        {
        }

        public void OdemeYap(int tutar)
        {
            emlakSatis.OdemeYap(this, tutar);
            Console.WriteLine($"Alıcı {tutar}₺ ödeme yapmıştır.");
        }
    }
}
