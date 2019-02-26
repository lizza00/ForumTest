using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace WebApp.Models
{
        public class LoginModel
        {
            [Required]
            public string Name { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public class RegisterModel
        {
            [Required]
            public string Email { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Пароли не совпадают")]
            public string ConfirmPassword { get; set; }

            
        }
    
    public class TopicModel
    {

        [Required(ErrorMessage = "Content required")]
        [StringLength(Int32.MaxValue, MinimumLength = 10)]
        public string TopicContent { get; set; }
    }
    public class ViewTopicModel
    {
        
            [Required(ErrorMessage = "Content required")]
        [StringLength(Int32.MaxValue, MinimumLength = 10)]
        public string MessageContent { get; set; }
    }
    public class SearchingTopics
    {
        private readonly WebApp.Models.TopicContext context;
        public SearchingTopics(TopicContext context)
        {
            this.context = context;
        }
        public SelectList Topics { get; set; }
    }
    
}