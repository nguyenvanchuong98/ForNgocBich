using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspboilerTraining.QuanLyDanhMuc.TinhThanh
{
    public class TinhThanh:Entity
    {
        [Key]
        [Required]
        public string matinh { get; set; }
        public string tentinh { get; set; }
        public string ghichu { get; set; }
    }
}
