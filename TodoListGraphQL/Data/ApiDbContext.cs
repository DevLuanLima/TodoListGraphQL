using Microsoft.EntityFrameworkCore;
using TodoListGraphQL.Models;

namespace TodoListGraphQL.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<ItemData> Items {get;set;}
        public virtual DbSet<ItemList> Lists {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<ItemData>(entity =>
            {
                entity.HasOne(d => d.ItemList)
                    .WithMany(p => p.ItemDatas)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemData_ItemList");
            });
        }
    }
}