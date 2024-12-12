﻿using System.Diagnostics.CodeAnalysis;

using Domain.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestAndBuidDevOps.Data;

public class ApplicationDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
{
    public ApplicationDbContext([NotNullAttribute] DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
        this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

    }
    public virtual DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
    public virtual DbSet<ProductEntity> Products { get; set; }
    public virtual DbSet<CategoryEntity> Categories { get; set; }
    public virtual DbSet<CartItemEntity> CartItems { get; set; }
    public virtual DbSet<OrderEntity> Orders { get; set; }
    public virtual DbSet<OrderItemEntity> OrderItems { get; set; }
    public virtual DbSet<ImageEntity> Images { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<RefreshTokenEntity>(entity =>
        {
            entity.ToTable("RefreshTokens");
            entity.HasKey("Id");
        });
        builder.Entity<CartItemEntity>()
                .HasKey(ci => new { ci.UserId, ci.ProductId });


        builder.Entity<OrderItemEntity>()
            .HasKey(oi => new { oi.OrderId, oi.ProductId });

        #region MyRegion

        builder.Entity<CategoryEntity>().HasData(
            new CategoryEntity
            {
                Id = Guid.Parse("03b15145-6597-4a71-82c7-14e36cfd6780"),
                Name = "Books",
                Url = "books"
            },
            new CategoryEntity
            {
                Id = Guid.Parse("6faadb7d-ef79-4f02-8fba-b25e76f70a2c"),
                Name = "Movies",
                Url = "movies"
            },
            new CategoryEntity
            {
                Id = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                Name = "Video Games",
                Url = "video-games"
            }
        );

        builder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    Id = Guid.Parse("8f6f4d09-4292-48cc-a8bf-76e7fe0bb961"),
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    CategoryId = Guid.Parse("03b15145-6597-4a71-82c7-14e36cfd6780"),
                    NewPrice = 123,
                    OriginalPrice = 345

                },
                new ProductEntity
                {
                    Id = Guid.Parse("e1cee7b3-a6ae-4ae3-bcf4-1955129d8197"),
                    Name = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    CategoryId = Guid.Parse("03b15145-6597-4a71-82c7-14e36cfd6780"),
                    NewPrice = 123,
                    OriginalPrice = 345
                },
                new ProductEntity
                {
                    Id = Guid.Parse("772bc058-2e46-4d3f-ac02-3dd4a6a5aced"),
                    Name = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                    CategoryId = Guid.Parse("03b15145-6597-4a71-82c7-14e36cfd6780"),
                    NewPrice = 123,
                    OriginalPrice = 345
                },
                new ProductEntity
                {
                    Id = Guid.Parse("71b5e16d-7c46-41b8-9b5a-cb00376c4b60"),
                    CategoryId = Guid.Parse("6faadb7d-ef79-4f02-8fba-b25e76f70a2c"),
                    Name = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345
                },
                new ProductEntity
                {
                    Id = Guid.Parse("0e7f6b60-6e98-4220-93ea-45f64e0f1aa2"),
                    CategoryId = Guid.Parse("6faadb7d-ef79-4f02-8fba-b25e76f70a2c"),
                    Name = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345

                },
                new ProductEntity
                {
                    Id = Guid.Parse("913f130b-c1b6-4a98-8d63-4cf316da3fc1"),
                    CategoryId = Guid.Parse("6faadb7d-ef79-4f02-8fba-b25e76f70a2c"),
                    Name = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345

                },
                new ProductEntity
                {
                    Id = Guid.Parse("453f44f7-e33e-4477-a2ad-a78e232db482"),
                    CategoryId = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                    Name = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345

                },
                new ProductEntity
                {
                    Id = Guid.Parse("5cda1ac6-7e1f-4f28-84e9-319455fc7016"),
                    CategoryId = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                    Name = "Diablo II",
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    NewPrice = 123,
                    OriginalPrice = 345
                },
                new ProductEntity
                {
                    Id = Guid.Parse("26429623-f8b1-49de-85a3-57e2c370afcb"),
                    CategoryId = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                    Name = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345

                },
                new ProductEntity
                {
                    Id = Guid.Parse("ff619bfc-5866-4a5b-9a95-9a8a0e457c91"),
                    CategoryId = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                    Name = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345
                },
                new ProductEntity
                {
                    Id = Guid.Parse("285a8637-e594-4729-b408-67819bb3e3e9"),
                    CategoryId = Guid.Parse("8dbb355f-bee4-4e1d-8081-fcfefebec213"),
                    Name = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    NewPrice = 123,
                    OriginalPrice = 345
                }
        );

        #endregion


        #region Data

        builder.Entity<RoleEntity>().HasData(new RoleEntity()
        {
            Id = Guid.Parse("ab251560-a455-40fd-adfd-54f9e150f874"),
            Name = "Administrator",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            NormalizedName = "ADMINISTRATOR"
        }, new RoleEntity()
        {
            Id = Guid.Parse("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c"),
            Name = "Employee",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            NormalizedName = "EMPLOYEE"
        }, new RoleEntity()
        {
            Id = Guid.Parse("f91ec0e5-d768-42e2-8926-de7d3162430f"),
            Name = "Customer",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            NormalizedName = "CUSTOMER"
        });



        builder.Entity<UserEntity>().HasData(new UserEntity()
        {
            Id = Guid.Parse("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
            UserName = "vankieu0409@gmail.com",
            NormalizedUserName = "VANKIEU0409@GMAIL.COM",
            SecurityStamp = Guid.NewGuid().ToString(),
            Email = "vankieu0409@gmail.com",
            PasswordHash = "AQAAAAEAACcQAAAAEMfrd51YGMSLzKs7NWUztJV/CKxRqpABxKVBI7+iwpeD82bZA8aBCnr7kKusapiDQw==",
            EmailConfirmed = true,
            NormalizedEmail = "VANKIEU0409@GMAIL.COM",
            PhoneNumber = "",
            PhoneNumberConfirmed = false,
            LockoutEnabled = false,
            LockoutEnd = DateTime.UtcNow,
            AccessFailedCount = 0,
            IsDeleted = false,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            TwoFactorEnabled = false,
            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2022/8/18/1082204/Leesuk.jpg",
            Decriptions = "",
            DisplayName = "Bậu",
            Address = "Tuân Chính -Vĩnh Tường - Vĩnh Phúc"
        }, new UserEntity()
        {
            Id = Guid.Parse("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
            UserName = "kieunvph14806@fpt.edu.vn",
            NormalizedUserName = "KIEUNVPH14806@FPT.EDU.VN",
            SecurityStamp = Guid.NewGuid().ToString(),
            Email = "kieunvph14806@fpt.edu.vn",
            PasswordHash = "AQAAAAEAACcQAAAAEMfrd51YGMSLzKs7NWUztJV/CKxRqpABxKVBI7+iwpeD82bZA8aBCnr7kKusapiDQw==",
            EmailConfirmed = true,
            NormalizedEmail = "KIEUNVPH14806@FPT.EDU.VN",
            PhoneNumber = "",
            PhoneNumberConfirmed = false,
            LockoutEnabled = false,
            LockoutEnd = DateTime.UtcNow,
            AccessFailedCount = 0,
            IsDeleted = false,
            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2022/8/18/1082204/Leesuk.jpg",
            Decriptions = " Chị rất nóng tính",
            DisplayName = "Chị Nhà Cục Súc",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            TwoFactorEnabled = false,
            Address = "Tuân Chính -Vĩnh Tường - Vĩnh Phúc"
        });
        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>()
        {
            UserId = Guid.Parse("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
            RoleId = Guid.Parse("ab251560-a455-40fd-adfd-54f9e150f874")
        }, new IdentityUserRole<Guid>()
        {
            UserId = Guid.Parse("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
            RoleId = Guid.Parse("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c")
        }, new IdentityUserRole<Guid>()
        {
            UserId = Guid.Parse("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
            RoleId = Guid.Parse("f91ec0e5-d768-42e2-8926-de7d3162430f"),
        });

        #endregion
    }
}