namespace TEST_SD.model;

public class User{

    public string id => Guid.NewGuid().ToString();

    public string email{get;set;}

    public string password{get;set;}

    public User(string email,string password){
        this.email = email;
        this.password=password;
    }    
    
}