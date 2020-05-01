

namespace M226BWetterSport {
    public class Verteidiger: Fussballspieler{
        public Verteidiger(string namen, string vornamen): base(namen, vornamen) {
        }
        public override string Typ(){
            return base.Typ() + " (Verteidiger)";
        }
    }
}
