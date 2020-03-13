public class Politiker extends Parteimitglied implements Lohn{
    private double lohn;
    private String rat = null;

    public Politiker(String vorname, String name){
        super(vorname, name);
    }

    public Politiker(String vorname, String name, double lohn, String rat, String partei){
        super(vorname, name, partei);
        this.lohn = lohn;
        this.rat = rat;
    }

    public void Datenausgabe(){

    }

    public double getLohn(){
        return lohn;
    }

    public void setLohn(double lohn){
        this.lohn = lohn;
    }

    public String getRat(){
        return rat;
    }

    public void setRat(String rat){
        this.rat = rat;
    }
}
