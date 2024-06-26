namespace OpenClose
{
    public class EmployeeFullTime : ISalary
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
 
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }
        public void CalculateSalary()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            Console.WriteLine($"Empleado: {Fullname}, Pago: {salary:C1}");
        }
    }
}