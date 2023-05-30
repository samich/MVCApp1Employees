namespace MVCApp1Employees.Models
{
    public class AddEmployeeViewModel
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public double Salary { get; set; }
        public string Department { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }


    }
}
