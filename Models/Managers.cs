using System.ComponentModel.DataAnnotations;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Managers
    {
        [Key]
        public int Manager_ID { get; set; }
        public string Manager_Name { get; set; }
        public string Manager_Phone_Number { get; set; }
        public string Manager_Email { get; set;}
        public string Manger_Nationality { get; set; }
    }
}
