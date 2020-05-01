

namespace M226BWetterSport {
    public class Stürmer:Fussballspieler {
        public Stürmer(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ(){
            return base.Typ() + " (Stürmer)";
        }
    }
}
