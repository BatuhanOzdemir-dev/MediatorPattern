using MediatorPatternEmlak.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternEmlak.Models
{
    public class Emlakci : Kisi
    {
        public Emlakci(IEmlakSatis emlakSatis) : base(emlakSatis)
        {
        }

        public void KomisyonAl(int tutar)
            => Console.WriteLine($"Emlakçı {tutar}₺ komisyon almıştır.");
    }
}
