using System.Runtime.ExceptionServices;

public class Student
{
    public static object Name { get; private set; }

    static void Main()
    {
        var students = new List<(string Name, int FirstExam, int SecondExam, int OralExam)>();

        double average;

        Console.Write("Lütfen Öğrenci sayısını giriniz: ");
        int studentNumber = int.Parse(Console.ReadLine());


        for (int i = 0; i < studentNumber; i++)
        {
            Console.Write("İsim:");
            string name = Console.ReadLine();

            Console.Write("1. Yazılı: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("2. Yazılı: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Sözlü: ");
            int oral = int.Parse(Console.ReadLine());
            
            students.Add((name, first, second, oral));

            average = (first + second + oral) / 3;

            if (average >= 50)
            {
                Console.WriteLine("Geçti");
            }

            else
            {
                Console.WriteLine("Kaldı");
            }

        }

        


        Console.Read();
    }
}