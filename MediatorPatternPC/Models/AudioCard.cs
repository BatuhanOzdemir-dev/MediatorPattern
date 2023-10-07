using MediatorPatternPC.Abstraction;

namespace MediatorPatternPC.Models
{
    public class AudioCard : Birim
    {
        public AudioCard(IAnakart anakart) : base(anakart)
        {
        }
        public void SesVer(string sesData)
        {
            string[] datas = sesData.Split(",");
            foreach (string data in datas)
                Console.WriteLine($"Gelen ses : {data}");
        }
    }
}
