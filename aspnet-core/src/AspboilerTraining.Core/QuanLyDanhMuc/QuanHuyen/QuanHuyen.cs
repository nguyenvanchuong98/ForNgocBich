using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using AspboilerTraining.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspboilerTraining.QuanLyDanhMuc.QuanHuyen
{
    public class QuanHuyen:Entity
    {
        [Key]
        [Required]
        public string mahuyen { get; set; }
        public string tenhuyen { get; set; }
        public string ghichu { get; set; }
        public string matinh { get; set; }
        [ForeignKey("matinh")]
        public TinhThanh.TinhThanh TinhThanh { get; set; }
    }
}
