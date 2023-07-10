using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using test2.MySQLConnection;
using test2.Repository;
using test2.Repository.Article;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IUserTbl, InMemUserTblRep>();
builder.Services.AddSingleton<IContactUsTbl,InMemContactRep>();
builder.Services.AddSingleton<IArticle, InMemArticleTblRep>();
builder.Services.AddControllers().AddNewtonsoftJson();
var app = builder.Build();
//MySql
//builder.Services.AddTransient<MySqlDatabase>(_ => new MySqlDatabase("Server=127.0.0.1;Port=3306;Database=test1;Uid=root;Pwd=12345678;"));
//builder.Services.AddEntityFrameworkMySQL().AddDbContext<DbContext>(options => {
//    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
//});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseHttpsRedirection();
app.MapControllers();


app.Run();

