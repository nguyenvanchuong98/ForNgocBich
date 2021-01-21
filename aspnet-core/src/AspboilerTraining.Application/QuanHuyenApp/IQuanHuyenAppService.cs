using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AspboilerTraining.QuanLyDanhMuc.QuanHuyen;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspboilerTraining.QuanHuyenApp
{
    public interface IQuanHuyenAppService:IApplicationService
    {
        Task<PagedResultDto<QuanHuyenDto>> GetAll(GetAllQuanhuyensInput input);
    }
}
