using System;
public class Mainclass
{
    public static void Main()
    {
        int hr, mn, ang;
        Console.WriteLine("Значение угла:");
        ang = int.Parse(Console.ReadLine());
        if (ang < 360 && ang >= 0)
        {
            mn = 2*(ang%30);
            hr = (ang - (ang % 30)) / 30;
            Console.WriteLine($"Часов полных: {hr}, минут: {mn}");
        }
    }
}