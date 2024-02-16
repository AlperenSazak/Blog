using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Runtime.ConstrainedExecution;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.Parse("E1F43848-56CA-4891-B34E-670AA0AE71C0"),
                Title = "Asp.Net Core Deneme Makalesi 1",
                Content = "Asp.Net Core bla bla bla",
                ViewCount = 15,                
                CategoryId = Guid.Parse("E1F43848-56CA-4891-B34E-670AA0AE71C0"),
                ImageId = Guid.Parse("773D14FC-26C8-4F54-B311-868D6DC32E4B"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("FF1DC87B-7F05-4E15-A11B-CE5B8A448DAC")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio bla bla bla",
                ViewCount = 15,   
                CategoryId = Guid.Parse("447C1313-F516-432B-BAB7-7F2DF36DBF8D"),
                ImageId = Guid.Parse("3F668C57-4B9B-4A24-A8FE-356732D57BE8"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("4473B6BC-3BE0-4BB0-A39F-3426CEC6FB03")
            }
            
            
            );
        }
    }
}
