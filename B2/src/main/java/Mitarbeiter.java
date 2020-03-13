public class Mitarbeiter extends Person implements Lohn{
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

    public String getFirma(){
        return firma;
    }

    public void setFirma(String firma){
        this.firma = firma;
    }

    public double getLohn(){
        return lohn;
    }

    public void setLohn(double lohn){
        this.lohn = lohn;
    }
}
