public class Person{
    private String name;
    private String vorname;

    public Person(String vorname, String name){
        this.vorname = vorname;
        this.name = name;
    }

    public void datenausgabe(){

    }

    public String getVorname(){
        return vorname;
    }

    public void setVorname(String vorname){
        this.vorname = vorname;
    }

    public String getName(){
        return name;
    }

    public void setName(String name){
        this.name = name;
    }
}
