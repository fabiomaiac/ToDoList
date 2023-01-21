using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Models;

namespace ToDo.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Email)
                .IsUnique();
            builder.Property(u => u.Email)
                .IsRequired();
            builder.Property(u => u.Senha)
                .IsRequired();
            builder.Property(u => u.Nome)
                .IsRequired();
            builder.HasMany(x => x.ToDos)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}