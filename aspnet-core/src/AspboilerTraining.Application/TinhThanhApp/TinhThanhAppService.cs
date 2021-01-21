using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using AspboilerTraining.QuanLyDanhMuc.TinhThanh;
using Microsoft.EntityFrameworkCore;


namespace AspboilerTraining.TinhThanhApp
{
    public class TinhThanhAppService : AspboilerTrainingAppServiceBase, ITinhThanhAppService
    {
        private readonly IRepository<TinhThanh> _tinhthanhRepository;

        public TinhThanhAppService(IRepository<TinhThanh> tinhthanhRepository)
        {
            _tinhthanhRepository = tinhthanhRepository;
        }
        //[AbpAuthorize(Permission.Pages_TinhThanh)]
        public async Task<PagedResultDto<TinhThanhDto>> GetAll(GetAllTinhthanhsInput input)
        {
            var tinhthanh = await _tinhthanhRepository
                .GetAll()
                .ToListAsync();
            var kq = new PagedResultDto<TinhThanhDto>();
            kq.TotalCount = tinhthanh.Count;
            kq.Items = ObjectMapper.Map<List<TinhThanhDto>>(tinhthanh);
            return kq; 
        }
    }
    //public class TinhThanhAppService : CrudAppService<TinhThanh, TinhThanhDto>
    //{
    //    public TinhThanhAppService(IRepository<TinhThanh, int> repository) : base(repository)
    //    {
    //    }
    //}
}
