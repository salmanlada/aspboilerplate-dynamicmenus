using Abp.Application.Navigation;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyApp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace MyApp.Nav
{
    [Table("Menus")]
    public class NavItems : Entity<int>
    {
        string name { get; set; }
        string permissionName { get; set; }
        string icon { get; set; }
        string route { get; set; }

        List<MenuDefinition> items { get; set; }
    }
}
