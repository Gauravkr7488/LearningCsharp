int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

int[] sophia = [90, 86, 87, 98, 100];
int[] andrew = [92, 89, 81, 96, 90];
int[] emma = [90, 85, 87, 98, 68];
int[] logan = [90, 95, 87, 88, 96];


int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

foreach (var item in sophia)
{
    sophiaSum += item;
}

foreach (var item in andrew)
{
    andrewSum += item;
}

foreach (var item in emma)
{
    emmaSum += item;
}

foreach (var item in logan)
{
    loganSum += item;
}

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

string[] grade = ["A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"];
int[] gradeScore = [97, 93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60, 0];

string? sophiaGrade = null;
// string? andrewGrade = null;
// string? emmaGrade = null;
// string? loganGrade = null;

for (int i = 0; i <= 12; i++)
{
    if (i == 0)
    {
        if (sophiaScore >= gradeScore[i])
        {
            sophiaGrade = grade[i];
        }
    }else if (i == 12)
    {
        if (sophiaScore <= gradeScore[i])
        {
            sophiaGrade = grade[i];
        }
    }
    else
    {
        if (sophiaScore == gradeScore[i])
        {
            sophiaGrade = grade[i];
        }else if (sophiaScore < gradeScore[i])
        {
            sophiaGrade = grade[i+1];
        }

    }

}

Console.WriteLine(sophiaGrade);
// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
