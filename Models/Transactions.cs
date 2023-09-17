using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Transactions
    {
        [Key]
        public int Transaction_ID { get; set; }
        public decimal Transaction_Fee { get; set; }
        [NotMapped]
        public DateOnly Transaction_Date { get; set; }
        public List<Players> Players { get; set; }
    }
}

