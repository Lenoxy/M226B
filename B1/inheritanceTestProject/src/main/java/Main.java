public class Main
{
    public static void main(String[] args){
        Auto a = new Auto("Mercedes");
        a.fahren();
        a.changeHandschuhfachState();

        Velo v = new Velo("Specialized");
        v.fahren();
    }
}
