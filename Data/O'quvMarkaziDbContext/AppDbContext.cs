using Domain.Entities.Administrators;
using Domain.Entities.Chat;
using Domain.Entities.Dedlines;
using Domain.Entities.Passvords;
using Domain.Entities.Payments;
using Domain.Entities.Rols;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Data.O_quvMarkaziDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Dedline> Dedline { get; set; }
        public DbSet<Passvord> passvords { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<ChatTeachAdm> chatTeachAdms { get; set; }
        public DbSet<ChatTeachStud> chatTeachStuds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = OquvMarkazi; Trusted_Connection = True");
        }
    }
}