using System;
using System.Collections.Generic;

namespace M226BWetterSport
{
    public class Program {
        static void Main(string[] args)
        {
            List<Person> allePersonen = new List<Person>();
            allePersonen.Add(new Pfarrer("Tarocci", "Don Camillo"));
            allePersonen.Add( new Surfer("Slater", "Kelly"));
            allePersonen.Add(new Tennisspieler("Djokovic", "Novak"));
            allePersonen.Add(new Velofahrer("Cancellara", "Fabian"));
            allePersonen.Add(new Stürmer("Derdiyok", "Eren"));
            allePersonen.Add(new Mittelfeldspieler("Barnetta", "Tranquillo"));
            allePersonen.Add(new Verteidiger("Philippe", "Senderos"));

            foreach (Person pe in allePersonen) {
                pe.Ausgabe();
            }
            System.Threading.Thread.Sleep(5000);
            Meteo.GetInstance().setWetter("Sonnenschein");

            System.Threading.Thread.Sleep(5000);
            Meteo.GetInstance().setWetter("Regen");


            Console.ReadLine();
        }


    }
}
