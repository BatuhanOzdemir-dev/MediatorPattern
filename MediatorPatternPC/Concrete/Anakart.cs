using MediatorPatternPC.Abstraction;
using MediatorPatternPC.Models;

namespace MediatorPatternPC.Concrete
{
    public class Anakart : IAnakart
    {
        CDDriver _cdDriver;
        CPU _cpu;
        GPU _gpu;
        AudioCard _audiocard;

        public CDDriver CDDriver { set => _cdDriver = value; }
        public CPU CPU { set => _cpu = value; }
        public GPU GPU { set => _gpu = value; }
        public AudioCard AudioCard { set => _audiocard = value; }

        public void Degistir(Birim birim)
        {
            if (birim is CDDriver)
            {
                string cdData = _cdDriver.CDData;
                _cpu.DataIsle(cdData);
            }
            else if (birim is CPU)
            {
                string videoData = _cpu.VideoData, sesData = _cpu.SesData;
                _gpu.GorselVer(videoData);
                _audiocard.SesVer(sesData);
            }
        }
    }
}
