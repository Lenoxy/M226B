

namespace M226BWetterSport {
    public class Pfarrer: Person
    {
        public Pfarrer(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ() {
            return base.Typ() + " ein Pfarrer";
        }
        
    }
}
