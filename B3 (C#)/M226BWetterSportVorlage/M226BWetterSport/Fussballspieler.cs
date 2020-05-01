
namespace M226BWetterSport {
    public class Fussballspieler: Sportler {
        public Fussballspieler(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ() {
            return base.Typ() + " ein Fussballspieler";
        }
    }
}
