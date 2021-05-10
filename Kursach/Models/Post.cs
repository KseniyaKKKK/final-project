using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursach.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string CampaignId { get; set; }
        public Campaign Campaign { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
