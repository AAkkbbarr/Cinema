using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<Cinema> Cinemas { get; set; }
        DbSet<Hall> Halls { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<MovieShowTime> MoviesShowTime { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Employee> Employees { get; set; }
    }
}
