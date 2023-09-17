using System.ComponentModel.DataAnnotations;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Positions
    {
        [Key]
        public int Positions_ID { get; set; }
        public int Position_Name { get; set; }
    }
}
