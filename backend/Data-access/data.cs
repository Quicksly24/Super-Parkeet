

using Microsoft.EntityFrameworkCore;
using TEST_SD.model;

public static class Data{

   public static Dbcontent makedata(){

     var option = new DbContextOptionsBuilder<Dbcontent>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
     var context = new Dbcontent(option);

     var resource2 = new Resource( Guid.NewGuid().ToString(),"Smartphone", "Apple", "SN67890");
     Resource resource1 = new Resource( Guid.NewGuid().ToString(),"Laptop", "Dell", "SN12345");



     context.resource.Add(resource1);
     context.resource.Add(resource2);
     
     context.SaveChanges();

     return context;
   }








}