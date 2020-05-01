using System;

namespace M226BWetterSport {
    public class Person {
        //Membervariablen

        //Konstruktoren
        public Person(string namen, string vornamen) {
            this.Namen = namen;
            this.Vornamen = vornamen;
        }
        //Methoden
        public string Namen { get; set; }
        public string Vornamen { get; set; }
       
        public virtual string Typ() {
            return "Ich bin " + Namen + " " + Vornamen;
        }
        public void Ausgabe() {
            Console.WriteLine(Typ());
        }

    }
}
