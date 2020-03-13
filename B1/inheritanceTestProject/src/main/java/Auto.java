public class Auto extends Fahrzeug implements Handschuhfach, Hupe{
    public Auto(String marke){
        super(4, marke);
    }

    @Override
    public void fahren(){
        System.out.println("brum brum");
    }

    public void changeHandschuhfachState(){
        System.out.println("dink");
    }

    public void closehandschuhfach(){
        System.out.println("click");
    }

    public void honk(){
        System.out.println("tüüüüüt");
    }
}
