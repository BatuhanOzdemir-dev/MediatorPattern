using MediatorPatternPC.Concrete;
using MediatorPatternPC.Models;

namespace MediatorPatternPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anakart anakart = new();

            CDDriver cdDriver = new(anakart);
            GPU gpu = new(anakart);
            CPU cpu = new(anakart);
            AudioCard audioCard = new(anakart);

            anakart.CDDriver = cdDriver;
            anakart.GPU = gpu;
            anakart.CPU = cpu;
            anakart.AudioCard = audioCard;

            cdDriver.CDOku();
        }
    }
}