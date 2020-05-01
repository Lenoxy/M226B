namespace M226BWetterSport
{
    public class Tennisspieler : Sportler, IWetterAbhaengig
    {
        public Tennisspieler(string namen, string vornamen) : base(namen, vornamen)
        {
            Meteo.GetInstance().Register(this);
        }

        public override string Typ()
        {
            return base.Typ() + " ein Tennisspieler";
        }

        public void Wetterbericht(string sWetter)
        {
            if (sWetter.Contains("Regen"))
            {
                Stop();
            }
            else
            {
                Start();
            }
        }
    }
}