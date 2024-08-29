using MicroserviceUser.Infraestructure.MongoAdapter.Interfaces;
using MicroserviceUser.Infraestructure.MongoAdapter.Repositories;
using MicroserviceUser.Infraestructure.MongoAdapter;
using MicroserviceUser.UsesCases.Gateway.Repositories;
using MicroserviceUser.UsesCases.Gateway;
using MicroserviceUser.UsesCases.UseCases;
using AutoMapper.Data;
using Users.Api.AutoMapper;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(config => config.AddDataReaderMapping(), typeof(ConfigurationProfile));

builder.Services.AddScoped<IUserUseCase, UserUseCase>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISurveyUseCase, SurveyUseCase>();
builder.Services.AddScoped<ISurveyRepository, SurveyRepository>();

builder.Services.AddCors(options =>
{

    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials(); ;
    });

});

builder.Services.AddSingleton<IContext>(provider => new Context(builder.Configuration.GetConnectionString("urlConnectionMongo"), "EstacolNews"));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Cross-Origin-Opener-Policy", "same-origin-allow-popups");
    context.Response.Headers.Add("Cross-Origin-Embedder-Policy", "require-corp");
    await next();
});
app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();



app.MapControllers();

app.Run();
