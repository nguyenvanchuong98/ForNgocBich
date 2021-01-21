using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace AspboilerTraining.QuanLyDanhMuc.QuanHuyen
{
    public class GetAllQuanhuyensInput
    {
        public string tenhuyen { get; set; }
    }
    [AutoMapFrom(typeof(QuanHuyen))]
    public class QuanHuyenDto:EntityDto<int>
    {
        public string mahuyen { get; set; }
        public string tenhuyen { get; set; }
        public string ghichu { get; set; }
        public string matinh { get; set; }
    }
}
