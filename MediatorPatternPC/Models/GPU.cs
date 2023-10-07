using MediatorPatternPC.Abstraction;

namespace MediatorPatternPC.Models
{
    public class GPU : Birim
    {
        public GPU(IAnakart anakart) : base(anakart)
        {
        }
        public void GorselVer(string videoData)
        {
            string[] datas = videoData.Split(",");
            foreach (string data in datas)
                Console.WriteLine($"Gelen görüntü : {data}");
        }
    }
}
