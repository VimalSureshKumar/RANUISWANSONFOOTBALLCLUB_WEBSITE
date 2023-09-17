using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Players
    {
        [Key]
        public int Player_ID { get; set; }
        public string Player_Name { get; set; }
        public string Player_Gender { get; set; }
        [NotMapped]
        public DateOnly Player_DOB { get; set; }
        public string Player_Phone_Number { get; set; }
        public string Player_Email { get; set; }
        public List<Coaches> Coaches { get; set; }
        public List<Teams> Teams { get; set; }
        public List<Positions> Positions { get; set; }
    }
}

