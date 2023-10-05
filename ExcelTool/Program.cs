using ExcelTool.Bl.IReposatory;
using ExcelTool.Bl.Reposatory;
using ExcelTool.DAL.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region SQLConnection
builder.Services.AddDbContext<AppDbContext>(opions =>
{
    opions.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
#endregion
builder.Services.AddControllers();
builder.Services.AddScoped<ISectionRepo, SectionRepo>();
builder.Services.AddScoped<IExcelRepo, ExcelRepo>();   

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

app.UseAuthorization();

app.MapControllers();

app.Run();
