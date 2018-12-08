using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace BuffteksWebsite.Models
{
    public class ProjectDetailViewModel
    {

        public Project TheProject {get; set;}

        public List<Client> ProjectClients { get; set; }
        
        public List<Member> ProjectMembers { get; set; }

        
    }
}