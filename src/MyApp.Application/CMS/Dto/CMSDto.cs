using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyApp.CMS.Dto
{
    [AutoMapTo(typeof(CMS))]
    [AutoMapFrom(typeof(CMS))]
    public class CMSDto : EntityDto<int>
    {
        [Required]
        public string PageName { get; set; }
        public string data { get; set; }

    }
}
