using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace BuffteksWebsite.Models
{
    public class Member : ProjectParticipant
    {
        [Display(Name = "Major")]                
        public string Major {get; set;}
    }
}