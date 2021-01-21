using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AspboilerTraining.Authorization.Roles;
using AspboilerTraining.Authorization.Users;
using AspboilerTraining.MultiTenancy;
using AspboilerTraining.QuanLyDanhMuc.QuanHuyen;
using AspboilerTraining.QuanLyDanhMuc.TinhThanh;
namespace AspboilerTraining.EntityFrameworkCore
{
    public class AspboilerTrainingDbContext : AbpZeroDbContext<Tenant, Role, User, AspboilerTrainingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<QuanHuyen> QuanHuyens { get; set; }
        public DbSet<TinhThanh> TinhThanhs { get; set; }
        public AspboilerTrainingDbContext(DbContextOptions<AspboilerTrainingDbContext> options)
            : base(options)
        {
        }
    }
}
