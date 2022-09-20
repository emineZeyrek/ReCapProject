using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//eðer data tutmuyorsak Singleton kullanýrýz

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//AOP
builder.Services.AddSingleton<ICarService,CarManager>();// biri constructor da ICarService isterse ona arka planda carManager new e ver
builder.Services.AddSingleton<ICarDal, EFCarDal>();
builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDal, EFBrandDal>();
builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDal, EFColorDal>();
builder.Services.AddSingleton<ICustomersService,CustomerManager>();
builder.Services.AddSingleton<ICustomerDal, EFCustomerDal>();
builder.Services.AddSingleton<IRentalService, RentalManager>();
builder.Services.AddSingleton<IRentalDal,EFRentalDal>();
builder.Services.AddSingleton<IUsersService,UserManager>();
builder.Services.AddSingleton<IUserDal,EFUserDal>();

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
