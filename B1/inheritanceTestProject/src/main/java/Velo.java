public class Velo extends Fahrzeug implements Hupe{
    public Velo(String marke){
        super(2, marke);
    }


    public void fahren(){
        System.out.println("zrttttt");
    }

    public void honk(){
        System.out.println("gling gling");
    }
}
