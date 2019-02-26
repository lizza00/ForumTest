using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TopicContext : DbContext
    {
        public TopicContext() : base("DefaultConnection")
        {

        }
        public DbSet<Topic> Topics { get; set; }
    }
}