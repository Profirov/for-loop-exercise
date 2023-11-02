
int n = int.Parse(Console.ReadLine());

int number = 0;

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;


for (int i = 0; i < n; i++)
{
    number = int.Parse(Console.ReadLine());
    if (number < 200)
    {
        p1++;
    }
    else if (number >= 200 && number < 400)
    {
        p2++;
    }
    else if (number >= 400 && number < 600)
    {
        p3++;
    }
    else if (number >= 600 && number < 800)
    {
        p4++;
    }
    else if (number >= 800)
    {
        p5++;
    }
}
Console.WriteLine($"{(double)p1 / n * 100:F2}%");
Console.WriteLine($"{(double)p2 / n * 100:F2}%");
Console.WriteLine($"{(double)p3 / n * 100:F2}%");
Console.WriteLine($"{(double)p4 / n * 100:F2}%");
Console.WriteLine($"{(double)p5 / n * 100:F2}%");