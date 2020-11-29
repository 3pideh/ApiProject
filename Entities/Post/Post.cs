using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Post : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int AuthorId { get; set; }

        public User Author { get; set; }
    }

    public class PostConfiguration:IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(post => post.Title).IsRequired().HasMaxLength(200);
            builder.Property(post => post.Description).IsRequired();
            builder.HasOne(post => post.Category).WithMany(c => c.Posts).HasForeignKey(post => post.CategoryId);
            builder.HasOne(post => post.Author).WithMany(c => c.Posts).HasForeignKey(post => post.AuthorId);
        }
    }
}
