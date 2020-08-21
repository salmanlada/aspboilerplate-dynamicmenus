﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyApp.Authorization;
using MyApp.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CMS
{
    //  [AbpAuthorize(PermissionNames.Pages_CMS)]
    public class CMSAppService : AsyncCrudAppService<CMS, CMSDto>, ICMSAppService
    {
        public CMSAppService(IRepository<CMS> repository) : base(repository)
        {
        }

        public  Task<CMSDto> GetCMSContent(EntityDto<int> PageId)
        {
            return base.Get(PageId);
        }

        public Task<CMSDto> InsertOrUpdateCMSContent(CMSDto Page)
        {
            if(Page.Id == 0)
            {
             return base.Create(Page);
            }
            else
            {
             return base.Update(Page);
            }
        }

        public override async Task<PagedResultDto<CMSDto>> GetAll(PagedAndSortedResultRequestDto input)
        {
            var result = await base.GetAll(input);
            return result;
        }

        public override Task<CMSDto> Update(CMSDto input)
        {
            return base.Update(input);
        }
    }
}
