using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ModGuideConverter.Core.Models;
using ModGuideConverter2.Data;

namespace ModGuideConverter2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            //Configure sql connections
            builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("sqlConnection")));

            //Configure identity services
            builder.Services.AddAuthentication();
            var identityBuilder = builder.Services.AddIdentityCore<ConverterUser>(options =>
            {
                options.User.RequireUniqueEmail = true;
            });
            identityBuilder = new IdentityBuilder(identityBuilder.UserType, typeof(IdentityRole), builder.Services);
            identityBuilder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(o =>
                {
                    //This allows any API request from any source. Can be further specified later.
                    o.AddPolicy("AllowAny", builder => 
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
                }
            );

            builder.Services.AddControllers();
            var app = builder.Build();

            app.UseCors("AllowAny");
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
        }
    }
}