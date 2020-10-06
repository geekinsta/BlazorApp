using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }
}
