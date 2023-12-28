class Employee
{
    public string LastName { get; set; }
    public double Salary { get; set; }
    public int StartYear { get; set; }

    public Employee(string lastName, double salary, int startYear)
    {
        LastName = lastName;
        Salary = salary;
        StartYear = startYear;
    }

    public int CalculateExperience()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - StartYear;
    }

    public int CalculateDaysSinceStartYear()
    {
        DateTime startDate = new DateTime(StartYear, 1, 1);
        TimeSpan timeSpan = DateTime.Now - startDate;
        return timeSpan.Days;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Иванов", 50000, 2015);

        int experience = employee.CalculateExperience();
        Console.WriteLine("Стаж работы: " + experience + " лет");

        int daysSinceStartYear = employee.CalculateDaysSinceStartYear();
        Console.WriteLine("Прошло дней с года поступления на работу: " + daysSinceStartYear + " дней");
    }
}
