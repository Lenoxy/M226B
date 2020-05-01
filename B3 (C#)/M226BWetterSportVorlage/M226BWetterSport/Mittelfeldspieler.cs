

namespace M226BWetterSport {
    public class Mittelfeldspieler: Fussballspieler {
        public Mittelfeldspieler(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ() {
            return base.Typ() + " (Mittelfeld)";
        }
    }
}
