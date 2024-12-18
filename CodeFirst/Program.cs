using CodeFirst;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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
static void Main(string[] args)
{
    using (var context = new PatikaFirstDbContext())
    {
        context.Database.EnsureCreated();

        Console.WriteLine("Veritabanı oluşturuldu.");
    };
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
