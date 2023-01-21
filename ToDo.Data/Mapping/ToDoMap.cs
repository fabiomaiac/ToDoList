using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Models;

namespace ToDo.Data.Mapping
{
    public class ToDoMap : IEntityTypeConfiguration<ToDoEntity>
    {
        public void Configure(EntityTypeBuilder<ToDoEntity> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Nome);
            builder.Property(u => u.Nome)
                .IsRequired();
            builder.Property(u => u.Descricao)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.ToDos)
                .HasForeignKey(x => x.UserId);

        }
    }
}