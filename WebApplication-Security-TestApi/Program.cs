var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var testPushProtectionKey = "ghp_000000000000000000000000000000000000";
var testPushProtectionKey2 = "ghp_000000000000000000000000000000000001";

var superSecretAPIKey = Guid.NewGuid().ToString("N");

var testPushProtectionKey3 = "ghp_000000000000000000000000000000000005";
var testPushProtectionKey4 = "ghp_000000000000000000000000000000000071";


var app = builder.Build();

app.MapDefaultEndpoints();

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
