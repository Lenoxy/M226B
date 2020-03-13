public class Parteimitglied extends Person{

    private String partei;


    public Parteimitglied(String vorname, String name){
        super(vorname, name);
    }

    public Parteimitglied(String vorname, String name, String partei){
        super(vorname, name);
        this.partei = partei;
    }

    public void Datenausgabe(){
        System.out.println();
    }

    public String getPartei(){
        return partei;
    }

    public void setPartei(String partei){
        this.partei = partei;
    }
}
