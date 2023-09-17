using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Coaches
    {
        [Key]
        public int Coaches_ID { get; set; }
        public string Coach_Name { get; set; }  
        public string Coach_Phone_Number { get; set; }
        public string Coach_Email { get; set; }
        public string Coach_Nationality { get; set; }

    }
}
