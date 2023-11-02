using System;

class Program
{
    static void Main()
    {
        string actorName = Console.ReadLine();
        double academyPoints = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double totalPoints = academyPoints;

        for (int i = 0; i < n; i++)
        {
            string judgeName = Console.ReadLine();
            double judgePoints = double.Parse(Console.ReadLine());

            totalPoints += judgeName.Length * judgePoints / 2;

            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                return;
            }
        }

        double neededPoints = 1250.5 - totalPoints;
        Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
    }
}

