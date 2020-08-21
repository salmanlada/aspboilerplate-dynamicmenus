using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyApp.CMS.Dto
{
    [AutoMapFrom(typeof(CMS))]
    public class CMSPageEditDto
    {
        [Required]
        public string PageName { get; set; }
        public string data { get; set; }
    }
}
