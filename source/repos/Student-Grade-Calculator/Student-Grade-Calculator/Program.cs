// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number of subject: ");

int numberOfSubjects = Convert.ToInt32(Console.ReadLine());

double[] grades = new double[numberOfSubjects];
double sum = 0;

for (int i = 0; i < numberOfSubjects; i++)
{
    Console.WriteLine($"Enter grade for subject {i + 1}: ");
    grades[i] = Convert.ToDouble(Console.ReadLine());
    sum += grades[i];
}
double average = sum / numberOfSubjects;

Console.WriteLine();
Console.WriteLine($"Total of subjects: {numberOfSubjects}");
Console.WriteLine($"Average grade: {average:F1}");
