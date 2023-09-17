using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Teams
    {
        public int Team_ID { get; set; }
        public string Team_Name { get; set; }
        public List<Managers> Managers { get; set; }
    }
}
