using Microsoft.EntityFrameworkCore;
using PapabearHRM.Models;

namespace PapabearHRM.Data
{
    public class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;
                }
                context.Employees.AddRange(
                            new Employee
                            {
                                Id = 1,
                                FirstName = "John",
                                LastName = "Doe",
                                Designation = "Software Engineer",
                                Salary = 75000,
                                DateOfBirth = new DateTime(1990, 5, 15)
                            },
    new Employee
    {
        Id = 2,
        FirstName = "Alice",
        LastName = "Johnson",
        Designation = "Marketing Manager",
        Salary = 85000,
        DateOfBirth = new DateTime(1988, 9, 22)
    },
    new Employee
    {
        Id = 3,
        FirstName = "Emily",
        LastName = "Smith",
        Designation = "HR Specialist",
        Salary = 65000,
        DateOfBirth = new DateTime(1993, 4, 10)
    },
    new Employee
    {
        Id = 4,
        FirstName = "Michael",
        LastName = "Brown",
        Designation = "Financial Analyst",
        Salary = 70000,
        DateOfBirth = new DateTime(1991, 7, 8)
    },
    new Employee
    {
        Id = 5,
        FirstName = "Sophia",
        LastName = "Miller",
        Designation = "Operations Manager",
        Salary = 90000,
        DateOfBirth = new DateTime(1985, 12, 18)
    },
    new Employee
    {
        Id = 6,
        FirstName = "William",
        LastName = "Garcia",
        Designation = "Sales Representative",
        Salary = 60000,
        DateOfBirth = new DateTime(1994, 8, 25)
    },
    new Employee
    {
        Id = 7,
        FirstName = "Olivia",
        LastName = "Davis",
        Designation = "Product Manager",
        Salary = 82000,
        DateOfBirth = new DateTime(1989, 3, 5)
    },
    new Employee
    {
        Id = 8,
        FirstName = "Daniel",
        LastName = "Wilson",
        Designation = "Customer Support Specialist",
        Salary = 58000,
        DateOfBirth = new DateTime(1992, 10, 12)
    },
    new Employee
    {
        Id = 9,
        FirstName = "Ava",
        LastName = "Taylor",
        Designation = "Data Analyst",
        Salary = 72000,
        DateOfBirth = new DateTime(1990, 2, 28)
    },
    new Employee
    {
        Id = 10,
        FirstName = "James",
        LastName = "Anderson",
        Designation = "Graphic Designer",
        Salary = 64000,
        DateOfBirth = new DateTime(1993, 6, 7)
    });
            }
        }
    }
}
