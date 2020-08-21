using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using MyApp.Nav.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Nav
{
    public class NavAppService : AsyncCrudAppService<NavItems,NavItemsDto>, INavAppService
    {
        public NavAppService(IRepository<NavItems> repository) : base(repository)
        {
        }


        public override Task<PagedResultDto<NavItemsDto>> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }

    }
}
