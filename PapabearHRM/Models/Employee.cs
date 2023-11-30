namespace PapabearHRM.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Designation { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
