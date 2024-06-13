namespace TEST_SD.model;

public class Resource{
    
    public string id => Guid.NewGuid().ToString();
    public string name{get;set;}
    public string brand{get;set;}
    public string serialnumber{get;set;}

    public Resource(string name,string brand,string img){

        this.name = name;
        this.brand = brand;
        this.serialnumber = img;

    }

}