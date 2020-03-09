﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class ValuesController : ApiController
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext()
                : base("DefaultConnection")
            {
            }

        public DbSet<EmployeeModel> Employees { get; set; }
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        //EmployeeModel employeeModel = new EmployeeModel();

        // GET api/values
        public IEnumerable<EmployeeModel> Get()
        {
            var list = _dbContext.Employees.ToList();
            return list;
        }

        // GET api/values/5
        public IEnumerable<EmployeeModel> Get(string Name)
        {
            var list = _dbContext.Employees.Where(e => e.FirstName.Contains(Name)).ToList();
            return list;
        }

        // POST api/values
        public void Post(string FirstName, string LastName, string Gender, int Salary)
        {
            EmployeeModel new_emp = new EmployeeModel
            {
                FirstName = FirstName,
                LastName = LastName,
                Salary = Salary,
                Gender = Gender
            };
            _dbContext.Employees.Add(new_emp);
            _dbContext.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, string FirstName, string LastName, string Gender, int Salary)
        {
            var emp = _dbContext.Employees.SingleOrDefault(e => e.Id == id);


            emp.FirstName = FirstName;
            emp.LastName = LastName;
            emp.Salary = Salary;
            emp.Gender = Gender;
            _dbContext.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var emp = _dbContext.Employees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
            }

        }
    }
}
