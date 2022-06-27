using Microsoft.AspNetCore.Builder;
using workshop01.Model;

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

    try
    {
        using var entitie = new AppDatabase();
        var amphursList = entitie.district.ToList();
        return amphursList;
    }
    catch
    {
        return null;
    }


});

app.MapGet("api/amphur/", (int id) =>
{

    try
    {
        using var entitie = new AppDatabase();
        var amphur = entitie.district.ToList();

        entitie.district.Where(x => x.amphur_id == id).ToList();

        //ADD
        //conf conflist = new conf() { config_name = "xxxx", config_value = "X", last_modify = null };
        //entitie.confs.Add(conflist);
        //districtList.config_value = "XXXD";
        //entitie.SaveChanges();
        return amphur;
    }
    catch //(Exception ex)
    {
        return null;// (ex.InnerException != null) ? (ex.InnerException.Message) : (ex.Message);
    }

});

//app.MapPost("api/amphur", () =>
//{
//    try
//    {
//        using var entitie = new AppDatabase();
//        district amphur = district() { amphur_id = 01, amphur_name = "พญาไท", province_id = 01 };

//        entitie.district.Add(amphur);
//        entitie.SaveChanges();

//        //ADD
//        //conf conflist = new conf() { config_name = "xxxx", config_value = "X", last_modify = null };
//        //entitie.confs.Add(conflist);
//        //districtList.config_value = "XXXD";
//        //entitie.SaveChanges();
//        //return amphur;
//    }
//    catch //(Exception ex)
//    {
//        return null;// (ex.InnerException != null) ? (ex.InnerException.Message) : (ex.Message);
//    }

//});

app.Run();