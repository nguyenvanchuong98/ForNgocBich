using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AspboilerTraining.Authorization;
using AspboilerTraining.QuanLyDanhMuc.QuanHuyen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspboilerTraining.QuanHuyenApp
{
    //[AbpAuthorize(PermissionNames.Pages_Quanhuyen)]
    public class QuanHuyenAppService : AspboilerTrainingAppServiceBase, IQuanHuyenAppService
    {
        private readonly IRepository<QuanHuyen> _quanhuyenRespository;
        public QuanHuyenAppService(IRepository<QuanHuyen> quanhuyenRespository)
        {
            _quanhuyenRespository = quanhuyenRespository;
        }
        
        public async Task<PagedResultDto<QuanHuyenDto>> GetAll(GetAllQuanhuyensInput input)
        {

            var quanhuyen = await _quanhuyenRespository
                .GetAll()
                .ToListAsync();
            var rskq = new PagedResultDto<QuanHuyenDto>();
            rskq.TotalCount = quanhuyen.Count;
            rskq.Items = ObjectMapper.Map<List<QuanHuyenDto>>(quanhuyen);
            return rskq;
        }
    }
}
