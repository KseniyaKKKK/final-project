using System;
namespace Kursach.Models
{
    public class Campaign
    {
        public string Name { get; set; }
        public User Owner { get; set; }
        public int WantedMoney { get; set; }
    }
}
