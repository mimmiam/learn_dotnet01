using Microsoft.AspNetCore.Builder;
using workshop01.Helper;
using workshop01.Model;
using workshop01.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("api/amphur", () => {
    try{
        var ampService = new AmphurService();
        var result = ampService.Get();
        return result;
    }catch{
        return null;
    }
});

app.MapGet("api/amphur/{id}", (int id) =>
{
    try{
        var ampService = new AmphurService();
        var result = ampService.Get(id);
        return result;
    }catch{
        return null;
    }
});

app.MapPost("api/amphur/", (int id, string name, int provinceID) =>
{
    var ampService = new AmphurService();
    ampService.Create(id, name, provinceID);
    return "success";
});

app.MapPut("api/amphur/{id}", (int id, string name) =>
{
    try{
        var ampService = new AmphurService();
        ampService.Update(id, name);
        return "success";
    }catch{
        return null;
    }

});

app.MapDelete("api/amphur/{id}", (int id) =>
{
    try{
        var ampService = new AmphurService();
        ampService.Delete(id);
        return "success";
    }catch{
        return null;
    }

});

app.Run();