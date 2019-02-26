using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Topic
    {
        [Key]
        [Column(Order = 2)]
        public string Name { get; set; }
        
        public string Author { get; set; }
        [Key]
        [Column(Order = 1)]
        public DateTime Date { get; set; }



        /* public Message this[int ind]
         {
             get => messages[ind];
             set { messages[ind] = value; }
         }*/
        public override bool Equals(object obj)
        {
            Topic t = (Topic)obj;
            return Name.Equals(t.Name)&&Date==t.Date;
        }

    }
}