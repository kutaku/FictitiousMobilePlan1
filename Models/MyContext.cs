using Microsoft.EntityFrameworkCore;

namespace FictitiousMobilePlan1.Models
{
	public class MyContext : DbContext
	{
		//コントラクタ
		public MyContext(DbContextOptions<MyContext> options) 
			: base(options) { }

		//モデルクラスへのアクセサ
		public DbSet<Phone> Phone { get; set; }
	}
}
