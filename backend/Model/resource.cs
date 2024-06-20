namespace TEST_SD.model;

public class Resource{
    
    public string id {get;set;}
    public string name{get;set;}
    public string brand{get;set;}
    public string serialnumber{get;set;}

    public Resource(string id,string name,string brand,string serialnumber){
        this.id = id;
        this.name = name;
        this.brand = brand;
        this.serialnumber = serialnumber;

    }

}