using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
        }
        public DbSet<Cinema> Cinemas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Hall> Halls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Movie> Movies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<MovieShowTime> MoviesShowTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Ticket> Tickets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<User> Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Employee> Employees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
