using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursach.Models
{
    public class Campaign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public int WantedMoney { get; set; }
        public int CollectedMoney { get; set; } = 0;
        public string Deskription { get; set; }
    }
}
