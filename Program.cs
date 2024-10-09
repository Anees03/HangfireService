using EmailServiceHangfire.Models;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Register your DbContext and other services
builder.Services.AddDbContext<HSMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HSMSDatabase")));

builder.Services.AddHangfire(config => config.UseSqlServerStorage(builder.Configuration.GetConnectionString("HSMSDatabase")));
builder.Services.AddHangfireServer();

builder.Services.AddTransient<EmailService>();
builder.Services.AddTransient<AttendanceReportService>();
builder.Services.AddTransient<EmailJob>();

builder.Services.AddControllers();

// Swagger configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EmailServiceHangfire API", Version = "v1" });
});

var app = builder.Build();

// Enable Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "EmailServiceHangfire API v1");
    });
}

app.UseHangfireDashboard();
app.MapControllers();

// Create a scope for the scoped service
using (var scope = app.Services.CreateScope())
{
    var emailJob = scope.ServiceProvider.GetRequiredService<EmailJob>();
    emailJob.ScheduleDailyEmailJob();
}

app.Run();
