using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace M226BWetterSport {
    public class Meteo
    {
        private static Meteo instance;

        private string wetter = "";
        private List<IWetterAbhaengig> toNotify = new List<IWetterAbhaengig>();

        public static Meteo GetInstance()
        {
            return Meteo.instance ?? (Meteo.instance = new Meteo());
        }

        public void Register(IWetterAbhaengig s) {
            if (!toNotify.Contains(s))
                toNotify.Add(s);
        }

        public void setWetter(string s) {
            Console.WriteLine("Neues Wetter: " + s);
            wetter = s;
            Notify();
        }
        public void Notify() {
            foreach (IWetterAbhaengig i in toNotify) {
                i.Wetterbericht(wetter);
            }
        } 
    }
}
