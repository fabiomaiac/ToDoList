using Microsoft.EntityFrameworkCore;
using ToDo.Data.Mapping;
using ToDo.Domain.Models;

namespace ToDo.Data.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
            
        }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ToDoEntity> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<ToDoEntity>(new ToDoMap().Configure);
        }
    }
}