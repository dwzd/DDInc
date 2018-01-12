using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDInc.Models
{
    public class Simple
    {
        [Display (Name = "Name")]
        public string Name { get; set; }

        [Display (Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}