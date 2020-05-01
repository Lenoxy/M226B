using System;


namespace M226BWetterSport
{
    public class Sportler : Person
    {
        public Sportler(string namen, string vornamen) : base(namen, vornamen)
        {
        }

        protected void Start()
        {
            Console.WriteLine(base.Typ() + ". Ich starte das Spiel.");
        }

        public void Stop()
        {
            Console.WriteLine(base.Typ() + ". Ich stoppe das Spiel.");
        }
    }
}