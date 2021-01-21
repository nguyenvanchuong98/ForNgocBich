using Abp.Application.Services.Dto;

namespace AspboilerTraining.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

