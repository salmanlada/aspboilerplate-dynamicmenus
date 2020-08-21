using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyApp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyApp.CMS
{
    [Table("CMSPages")]
    public class CMS : Entity<int>
    {
        public string PageName { get; set; }
        public string data { get; set; }
        
    }
}
