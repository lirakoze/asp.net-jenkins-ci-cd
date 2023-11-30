using Moq;
using PapabearHRM.Data;
using PapabearHRM.Models;
using PapabearHRM.Services;

namespace PapabearHRM.Tests
{
    [TestClass]
    internal class EmployeeServiceTests
    {
        private EmployeeRepository _employeeRepository;
        private Mock<AppDbContext> _mockContext;

        
        public void Setup()
        {
            _mockContext = new Mock<AppDbContext>();
            _employeeRepository = new EmployeeRepository(_mockContext.Object);
        }

        [TestMethod]
        public async Task SelectAllEmployees_ReturnsListOfEmployees()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Designation = "Engineer" },
                new Employee { Id = 2, FirstName = "Alice", LastName = "Smith", Designation = "Manager" }
                
            };

            _mockContext.Setup(c => c.Employees.ToList()).Returns(employees);

            // Act
            var result = await _employeeRepository.SelectAllEmployees();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(employees.Count, result.Count());
            
        }

        [TestMethod]
        public async Task UpdateEmployee_ReturnsSuccessMessage()
        {
            // Arrange
            var idToUpdate = 1;
            var employeeToUpdate = new Employee { Id = idToUpdate, FirstName = "UpdatedName", LastName = "UpdatedLastName", Designation = "UpdatedDesignation" };
            var existingEmployee = new Employee { Id = idToUpdate, FirstName = "John", LastName = "Doe", Designation = "Engineer" };

            _mockContext.Setup(c => c.Employees.FindAsync(idToUpdate)).ReturnsAsync(existingEmployee);

            // Act
            var result = await _employeeRepository.UpdateEmployee(idToUpdate, employeeToUpdate);

            // Assert
            Assert.AreEqual("Data updated successfully!", result);
            
        }

    }
}
