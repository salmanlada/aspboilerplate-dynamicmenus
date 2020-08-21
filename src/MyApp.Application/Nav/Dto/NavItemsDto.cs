using Abp.Application.Navigation;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Nav.Dto
{
    [AutoMapTo(typeof(NavItems))]
    [AutoMapFrom(typeof(NavItems))]
    public class NavItemsDto : EntityDto<int>
    {

        string name { get; set; }
        string    permissionName { get; set; }
        string icon { get; set; }
        string route { get; set; }

        List<MenuDefinition> items { get; set; }
    }
}
