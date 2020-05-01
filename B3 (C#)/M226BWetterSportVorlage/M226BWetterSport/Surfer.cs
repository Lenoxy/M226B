namespace M226BWetterSport
{
    public class Surfer : Sportler, IWetterAbhaengig
    {
        public Surfer(string namen, string vornamen) : base(namen, vornamen)
        {
            Meteo.GetInstance().Register(this);
        }

        public override string Typ()
        {
            return base.Typ() + " ein Surfer";
        }

        public void Wetterbericht(string sWetter)
        {
            if (sWetter.Contains("Regen"))
            {
                Start();
            }
            else
            {
                Stop();
            }
        }
    }
}