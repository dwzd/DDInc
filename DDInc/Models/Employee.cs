using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DDInc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Age { get; set; }
    }
    public class EmployeeDBContext: DbContext  //EmployeeDBContext类继承自EF提供的DbContext。EmployeeDBContext代表Employee的数据库上下文，负责处理数据的增删改查操作
    {
        //将C#的Employee类映射到数据库的Employee表
        public DbSet<Employee> Employees { get; set; }  //为EF持久化添加的代码
    }

}