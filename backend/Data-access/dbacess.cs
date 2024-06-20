
using Microsoft.EntityFrameworkCore;
using TEST_SD.model;

public class Dbcontent:DbContext{



    public Dbcontent(DbContextOptions<Dbcontent> context):base(context){

    }
    public DbSet<Resource> resource{get;set;}

    protected override void OnModelCreating(ModelBuilder builder){

        builder.Entity<Resource>().HasKey(x=>x.id);
        
    }

}