using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;
using System.ComponentModel.DataAnnotations;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Teams
    {
        [Key]
        public int Team_ID { get; set; }
        public string Team_Name { get; set; }
        public List<Managers> Managers { get; set; }
    }
}
