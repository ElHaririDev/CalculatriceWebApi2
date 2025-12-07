using Calculatrice.Services;

var builder = WebApplication.CreateBuilder(args);

// Ajouter le service de calculatrice
builder.Services.AddSingleton<CalculatorService>();

// Ajouter les services pour les Controllers et Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Optionnel : Configurer CORS si tu veux connecter un frontend React
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // URL de ton frontend React
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Activer Swagger uniquement en mode Développement
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Activer CORS pour React
app.UseCors("AllowReactApp");

app.UseAuthorization();

// Mapper les Controllers
app.MapControllers();

app.Run();
