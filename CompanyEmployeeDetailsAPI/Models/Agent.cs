using System.ComponentModel.DataAnnotations;

namespace Demo_Company_API.Models
{
    public class Agent
    {
        [Key]
        public string AGENT_CODE { get; set; }
        public string AGENT_NAME { get; set; }
        public string WORKING_AREA { get; set; }
        public int COMMISSION { get; set; }
        public string PHONE_NO { get; set; }
        public string COUNTRY { get; set; }
    }
}
