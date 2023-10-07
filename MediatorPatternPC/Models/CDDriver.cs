using MediatorPatternPC.Abstraction;

namespace MediatorPatternPC.Models
{
    public class CDDriver : Birim
    {
        public CDDriver(IAnakart anakart) : base(anakart)
        {
        }

        string _cdData;
        public string CDData => _cdData;
        public void CDOku()
        {
            _cdData = "görüntü1,görüntü2,görüntü3*ses1,ses2,ses3";
            _anakart.Degistir(this);
        }
    }
}
