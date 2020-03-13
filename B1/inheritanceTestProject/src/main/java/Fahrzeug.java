public abstract class Fahrzeug{
    public Fahrzeug(int raeder, String marke){
        this.raeder = raeder;
        this.marke = marke;
    }

    String marke;
    int raeder;

    public abstract void fahren();

    public int getRaeder(){
        return raeder;
    }

    public void setRaeder(int raeder){
        this.raeder = raeder;
    }

    public String getMarke(){
        return marke;
    }

    public void setMarke(String marke){
        this.marke = marke;
    }

}
