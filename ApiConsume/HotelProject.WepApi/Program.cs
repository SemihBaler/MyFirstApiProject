using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.EntityFramework;
using System.Numerics;

namespace HotelProject.WepApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<IStaffDal,EFStaffDal>();
            builder.Services.AddScoped<IStaffService,StaffManager>();

            builder.Services.AddScoped<IRoomDal,EFRoomDal>();
            builder.Services.AddScoped<IRoomService,RoomManager>();

            builder.Services.AddScoped<ISubscribeDal, EFSubscribeDal>();
            builder.Services.AddScoped<ISubscribeService,SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDal,EFTestimonialDal>();
            builder.Services.AddScoped<ITestimonialService,TestimonialManager>();

            builder.Services.AddScoped<IServiceDal, EFServiceDal>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IAboutService,AboutManager >();
            builder.Services.AddScoped<IAboutDal,EFAboutDal>();

            builder.Services.AddScoped<IBookingDal,EFBookingDal>();
            builder.Services.AddScoped<IBookingService,BookingManager>();


            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("OtelApiCors", opts =>
                {
                    opts.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            });
            


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

            app.UseCors("OtelApiCors");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}