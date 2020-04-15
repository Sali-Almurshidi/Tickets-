using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace plz.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        public string Title { get; set; }

    }
}
