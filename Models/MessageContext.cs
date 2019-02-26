using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MessageContext:DbContext
    {
        public MessageContext() : base("DefaultConnection")
        {

        }
        public DbSet<Message> Messages { get; set; }
    }
}