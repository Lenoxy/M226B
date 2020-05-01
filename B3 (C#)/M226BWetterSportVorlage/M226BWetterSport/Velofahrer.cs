

namespace M226BWetterSport {
    public class Velofahrer: Sportler {
        public Velofahrer(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ() {
            return base.Typ() + " ein Velofahrer";
        }
    }
}
