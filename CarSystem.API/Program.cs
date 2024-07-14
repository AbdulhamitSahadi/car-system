using CarSystem.API.Data;
using CarSystem.API.Models.Mappers;
using CarSystem.API.Repositories.IRepositories;
using CarSystem.API.Repositories.Reposiltory;
using CarSystem.API.Repositories.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Registering Sql Server to DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionString"));
});

//Registering AutoMapper
builder.Services.AddAutoMapper(typeof(MappingConfig));


//Registering Repositories to DI container
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IDamageLicenseRepository, DamageLicenseRepository>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();
builder.Services.AddScoped<ILicenseRepository, LicenseRepository>();
builder.Services.AddScoped<ILicenseClassRepository, LicenseClassRepository>();
builder.Services.AddScoped<ILostLicenseRepository, LostLicenseRepository>();
builder.Services.AddScoped<INationalityRepository, NationalityRepository>();
builder.Services.AddScoped<IOptionRepository, OptionRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IRenewalLicenseRepository, RenewalLicenseRepository>();
builder.Services.AddScoped<ITestCategoryRepository, TestCategoryRepository>();
builder.Services.AddScoped<ITestRepository, TestRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVisionTestRepository, VisionTestRepository>();
builder.Services.AddScoped<IWritingTestRepository, WritingTestRepository>();


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
