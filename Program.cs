namespace ADO.NET_PayrollService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To SQL Program");
            EmployeeRepository.GetAllEmployee();
            Console.ReadLine();
        }
    }
}