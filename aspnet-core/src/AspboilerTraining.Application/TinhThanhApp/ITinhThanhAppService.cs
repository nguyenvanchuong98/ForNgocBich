using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AspboilerTraining.QuanLyDanhMuc.TinhThanh;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspboilerTraining.TinhThanhApp
{
    public interface ITinhThanhAppService : IApplicationService
    {
        Task<PagedResultDto<TinhThanhDto>> GetAll(GetAllTinhthanhsInput input);
    }
}
