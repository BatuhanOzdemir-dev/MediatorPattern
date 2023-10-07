namespace MediatorPatternPC.Abstraction
{
    public abstract class Birim
    {
        protected IAnakart _anakart;
        protected Birim(IAnakart anakart)
        {
            _anakart = anakart;
        }
    }
}
