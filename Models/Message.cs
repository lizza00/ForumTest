using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Message
    {
        [Key]
        [Column(Order = 1)]
        public Topic Parent { get; set; }
        public string Text { get; set; }
        [Key]
        [Column(Order = 3)]
        public string Author { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }
    }
}