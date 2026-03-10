namespace apbd_2026_eng_13c;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("First change");

        double[] values = [9.0, 9.2, 3.1, 5.1, 5.0, 4.2, 4.3];
        double res = StatisticsHelper.Mean(values);
        Console.WriteLine($"Mean: {res}");
        
        String username = Console.ReadLine();
        Console.WriteLine(UserValidator.usernameValidator(username));
    }

    public static double calculateAvg(int[] val)
    {
        return val.Average();
    }
}