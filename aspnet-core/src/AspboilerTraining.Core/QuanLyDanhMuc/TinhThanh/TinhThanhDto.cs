using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Nest;

namespace AspboilerTraining.QuanLyDanhMuc.TinhThanh
{
    public class GetAllTinhthanhsInput
    {
        public string tentinh { get; set; }
    }
    [AutoMapFrom(typeof(TinhThanh))]
    public class TinhThanhDto:EntityDto<int>
    {
        public string matinh { get; set; }
        public string tentinh { get; set; }
        public string ghichu { get; set; }
    }
}
