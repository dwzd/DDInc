using DDInc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DDInc.DAL
{
    public class CompanyContext : DbContext  //数据库上下文继承EF中的DbContext基类
    {
        public CompanyContext() : base("CompanyContext") //CompanyContext 继承基类DbContext的构造函数
        {

        }

        public DbSet<Worker> Workers { get; set; }  //表示Model Worker和CompanyContext中的数据集Workers对应

        //定义了一个事件 OnModelCreating，这个事件在我们使用的Code First方法在数据库中创建数据表时触发
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //我们创建出来的数据库表名字都是单数，不是复数。也就是说将来的数据库表名是Worker而不是Workers。这也是我们创建数据库表的习惯命名方法。
        }

    }
}