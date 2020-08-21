using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyApp.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CMS
{
    public interface ICMSAppService : IAsyncCrudAppService<CMSDto>
    {
        Task<CMSDto> GetCMSContent(EntityDto<int> PageId);
        Task<CMSDto> InsertOrUpdateCMSContent(CMSDto Page);
    }
}
