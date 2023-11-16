using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PetShopAlgebraProject.Models;
using System.Reflection.Emit;

namespace PetShopAlgebraProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "User", NormalizedName = "USER" }
                );


            builder.Entity<Pet>().HasData(
                new Pet { Id = 1, Name = "Felix", Description = "Teritorijalna, nije dobra s drugim životinjama", Price = 25.50M, Image = "Felix.jpg" },
                new Pet { Id = 2, Name = "Tom", Description = "Živahan i veseo mačak", Price = 30M, Image = "Tom.jpg" },
                new Pet { Id = 3, Name = "Sylvester", Description = "Umiljat, prelijepog krzna", Price = 28M, Image = "Sylvester.jpg" },
                new Pet { Id = 4, Name = "Dumbo", Description = "Mirna životinja", Price = 650M, Image = "Dumbo.jpg" },
                new Pet { Id = 5, Name = "Karlo", Description = "Razigran i pametan ljubimac", Price = 200M, Image = "Karlo.jpg" },
                new Pet { Id = 6, Name = "Goran", Description = "Samo za stručne vlasnike", Price = 300M, Image = "Goran.jpg" },
                new Pet { Id = 7, Name = "Smoki", Description = "Vjeran i drag", Price = 20M, Image = "Smoki.jpg" },
                new Pet { Id = 8, Name = "Floki", Description = "Odrastao u divljini, nezahtjevan a privržen", Price = 15M, Image = "Floki.jpg" },
                new Pet { Id = 9, Name = "Bobi", Description = "Razigrana čivava", Price = 45M, Image = "Bobi.jpg" },
                new Pet { Id = 10, Name = "Sebastijan", Description = "Prekrasne zelene boje", Price = 70M, Image = "Sebastijan.jpg" },
                new Pet { Id = 11, Name = "John Cena", Description = "Now you see him...", Price = 130M, Image = "John_Cena.jpg" },
                new Pet { Id = 12, Name = "Alain", Description = "Uzgojen za prehranu", Price = 2M, Image = "Alain.jpg" },
                new Pet { Id = 13, Name = "Pero", Description = "Jako veseo i razigran hrčak", Price = 10M, Image = "Pero.jpg" },
                new Pet { Id = 14, Name = "Charlie", Description = "Draga životinja, osobito djeci, ali voli ugristi", Price = 30M, Image = "Charlie.jpg" },
                new Pet { Id = 15, Name = "Baltazar", Description = "Samo uz predodžbu potrebnih dozvola", Price = 450M, Image = "Baltazar.jpg" });

            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Title = "Mačka" },
                new Category() { Id = 2, Title = "Pas" },
                new Category() { Id = 3, Title = "Slon" },
                new Category() { Id = 4, Title = "Iguana" },
                new Category() { Id = 5, Title = "Čimpanza" },
                new Category() { Id = 6, Title = "Gorila" },
                new Category() { Id = 7, Title = "Lav" },
                new Category() { Id = 8, Title = "Žohar" },
                new Category() { Id = 9, Title = "Kameleon" },
                new Category() { Id = 10, Title = "Činčila" },
                new Category() { Id = 11, Title = "Hrčak" }
                );

            builder.Entity<PetCategory>().HasData(
                new PetCategory() { Id = 1, CategoryId = 1, PetId = 1},
                new PetCategory() { Id = 2, CategoryId = 1, PetId = 2 },
                new PetCategory() { Id = 3, CategoryId = 1, PetId = 3 },
                new PetCategory() { Id = 4, CategoryId = 2, PetId = 7 },
                new PetCategory() { Id = 5, CategoryId = 2, PetId = 8 },
                new PetCategory() { Id = 6, CategoryId = 2, PetId = 9 },
                new PetCategory() { Id = 7, CategoryId = 3, PetId = 4 },
                new PetCategory() { Id = 8, CategoryId = 4, PetId = 10 },
                new PetCategory() { Id = 9, CategoryId = 5, PetId = 5 },
                new PetCategory() { Id = 10, CategoryId = 6, PetId = 6 },
                new PetCategory() { Id = 11, CategoryId = 7, PetId = 15 },
                new PetCategory() { Id = 12, CategoryId = 8, PetId = 12 },
                new PetCategory() { Id = 13, CategoryId = 9, PetId = 11 },
                new PetCategory() { Id = 14, CategoryId = 10, PetId = 14 },
                new PetCategory() { Id = 15, CategoryId = 11, PetId = 13 }
                );

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetStatus> Status { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PetCategory> PetCategory { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string? FirstName { get; set; }

        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(200)]
        public string? City { get; set; }

        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }

        [StringLength(100)]
        public string? Country { get; set; }


        [ForeignKey("UserId")]
        public virtual ICollection<PetStatus> Status { get; set; }
    }

}