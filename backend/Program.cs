var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(opt => Data.makedata());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if(app.Environment.IsDevelopment()){
    app.UseCors(opt=>{

        opt.AllowAnyOrigin();
    });
}
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

