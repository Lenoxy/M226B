public class Mitarbeiter extends Person{
    private double lohn;
    private String firma;

    public Mitarbeiter(String vorname, String name){
        super(vorname, name);
    }

    public Mitarbeiter(String vorname, String name, double lohn, String firma){
        super(vorname, name);
        this.lohn = lohn;
        this.firma = firma;
    }

    public void datenausgabe(){

    }
}
