using Data.Data;
using Data.Interface;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("connectString")));

builder.Services.AddScoped<AdminInterface, AdminRepository>();
builder.Services.AddScoped<FacultyInterface, FacultyRepository>();
builder.Services.AddScoped<StudentInterface, StudentRepisitory>();
builder.Services.AddScoped<SurveyInterface, SurveyRepository>();
builder.Services.AddScoped<ResponseInterface, ResponseRepository>();
builder.Services.AddScoped<FAQInterface, FAQRepository>();
builder.Services.AddScoped<EventInterface, EventRepository>();
builder.Services.AddScoped<AnswerInterface, AnswerRepository>();
builder.Services.AddScoped<CompetitionInterface, CompetitionRepository>();
builder.Services.AddScoped<QuestionInterface, QuestionRepository>();
builder.Services.AddScoped<ExamInterface, ExamRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
