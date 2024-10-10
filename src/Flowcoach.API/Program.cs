using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IRepository<Card>, Repository<Card>>();
builder.Services.AddScoped<IRepository<BodyFlowArticle>, Repository<BodyFlowArticle>>();
builder.Services.AddScoped<IRepository<BodyFlowCard>, Repository<BodyFlowCard>>();
builder.Services.AddScoped<IRepository<CoachingSession>, Repository<CoachingSession>>();
builder.Services.AddScoped<IRepository<EmotionCard>, Repository<EmotionCard>>();
builder.Services.AddScoped<IRepository<FlowcoachCard>, Repository<FlowcoachCard>>();
builder.Services.AddScoped<IRepository<JournalEntry>, Repository<JournalEntry>>();
builder.Services.AddScoped<IRepository<SelfcareCard>, Repository<SelfcareCard>>();
builder.Services.AddScoped<IRepository<SelfCareArticle>, Repository<SelfCareArticle>>();

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
