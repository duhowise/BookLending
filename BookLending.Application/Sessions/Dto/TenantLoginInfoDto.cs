using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BookLending.MultiTenancy;

namespace BookLending.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}