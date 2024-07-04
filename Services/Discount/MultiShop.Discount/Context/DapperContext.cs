using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MultiShop.Discount.Entities;
using System.Data;

namespace MultiShop.Discount.Context
{
	public class DapperContext : DbContext //ORM kütüphanesi
	{
		private readonly IConfiguration _configuration; //appsettings.json dosyasındaki ayarları içerir
		private readonly string _connectionString;
		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("DefaultConnection");
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LAPTOP-P1TC8HDR\\MSSQL;initial Catalog=MultiShopDiscountDb;integrated Security=true");
		}
		public DbSet<Coupon> Coupons { get; set; }
		public IDbConnection CreateConnection() => new SqlConnection(_connectionString); //Bu metod, _connectionString kullanarak yeni bir SqlConnection nesnesi oluşturur ve döndürür. Bu, Dapper kullanarak veritabanına bağlanmak için kullanılır.
	} 
}
