namespace apbd_2026_eng_13c;

public class StatisticsHelper
{
    public static double Mean(double[] values)
    {
        return values.Sum() / values.Length;
    }
}