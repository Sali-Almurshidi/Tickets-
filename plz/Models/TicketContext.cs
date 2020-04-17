using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using plz.Models;

namespace plz.Models
{
    public class TicketContext:DbContext
    {
        //ctor
        public TicketContext(DbContextOptions<TicketContext> options):base (options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
