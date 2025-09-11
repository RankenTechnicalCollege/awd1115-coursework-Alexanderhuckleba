int[] testScores = [100, 90, 30, 88, 75, 93];


int bestScore = 0;
int worstScore  = 0;
int sum  = 0;

for (int i = 0; i < testScores.Length; i++)
{
    if (testScores[i] > bestScore) ;
    {
        bestScore = testScores[i];
    }
    if (testScores[i] < worstScore)
    {
        worstScore = testScores[i];
    }
    sum += testScores[i];
}

double average = sum / testScores.Length;
Console.WriteLine($"Best Score: {bestScore}");
Console.WriteLine($"Worst Score: {worstScore}");
Console.WriteLine($"Average Score: {average}");
Console.WriteLine($"Sum of Scores: {sum}");