using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication_CustomAttribute.CustomAttribute;

namespace WebApplication_CustomAttribute.Models
{
    public class ExampleModel
    {
        [Required]
        [ExampleAttribute]
        public string FirstName { get; set; }
        
        [Required]
        [ExampleAttribute(new string[] { "安","1"})]
        public string LastName { get; set; }
    }
}