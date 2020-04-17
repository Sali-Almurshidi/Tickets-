using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName ("Ticket Title")]
        [Required (ErrorMessage ="Enter the title")]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime? CloseTime { get; set; }

        public int Status { get; set; }

        public User User { get; set; }

    }
}
