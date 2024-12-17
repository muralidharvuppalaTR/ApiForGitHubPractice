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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class Example
{
    public int AddNumbers(int a, int b)
    {
        // Potential bug: incorrect addition
        return a - b;
    }

    public void ProcessData()
    {
        var data = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var item in data)
        {
            // Poor naming convention: 'i' is not descriptive
            var i = item * 2;
            Console.WriteLine(i);
        }
    }
}
