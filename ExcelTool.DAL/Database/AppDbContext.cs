namespace ExcelTool.DAL.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<StoreSction> StoreSections { get; set; }
    }
}
