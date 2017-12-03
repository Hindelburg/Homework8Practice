using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW8Practice.Models
{
    public class RestrictedDate : ValidationAttribute
    {
        public override bool IsValid(object date)
        {
            DateTime date2 = (DateTime)date;
            return date2 < DateTime.Now;
        }
    }
}