using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models
{
    public class Transactions
    {
        public int Transaction_ID { get; set; }
        public decimal Transaction_Fee { get; set; }
        public DateOnly Transaction_Date { get; set; }
        public List<Players> Players { get; set; }
    }
}
