namespace Modulo11;

public class TrabData
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2021, 12, 02, 19, 22, 23);
        var date2 = DateTime.Parse("2023/12/15 11:38:10");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));

        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);

    }

    public void AulaSubDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        var diff = date1 - date2;

        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine(diff.TotalHours);
    }

    public void AulaAddDatas()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(3));
        Console.WriteLine(date1.AddMonths(1));
        Console.WriteLine(date1.AddYears(2));
    }

    public void AulaAddHoras()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddHours(3));
        Console.WriteLine(date1.AddDays(10));
        Console.WriteLine(date1.AddSeconds(200));
    }

    public void AulaRecData()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        var date1 = new DateOnly(2022, 12, 2);
        //var date1 = DateOnly.Parse("2022-02-01");

        Console.WriteLine(date1);
    }

    public void AulaTimeOnly()
    {
        //var date1 = new TimeOnly(23, 1, 23,0);
        var date1 = TimeOnly.Parse("23:09:45");

        Console.WriteLine(date1);
    }
}