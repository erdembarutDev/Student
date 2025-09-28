class Program
{
    static void Main()
    {
        List<Lesson> students = new List<Lesson>();

        Console.Write("Kaç öğrenci gireceksiniz? ");
        int studentNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentNumber; i++)
        {
            Lesson student = new Lesson();

            Console.Write("İsim: ");
            student.Name = Console.ReadLine();
            Console.Write("Matematik: ");
            student.Matematik = int.Parse(Console.ReadLine());
            Console.Write("Fizik: ");
            student.Fizik = int.Parse(Console.ReadLine());
            Console.Write("Kimya: ");
            student.Kimya = int.Parse(Console.ReadLine());
            Console.Write("Biyoloji: ");
            student.Biyoloji = int.Parse(Console.ReadLine());
            Console.Write("Tarih: ");
            student.Tarih = int.Parse(Console.ReadLine());
            Console.Write("Coğrafya: ");
            student.Cografya = int.Parse(Console.ReadLine());
            

            students.Add(student);
        }

        foreach (var student in students)
        {
            string result = student.Average() >= 50 ? "Geçti" : "Kaldı";
            Console.WriteLine($"{student.Name} - Ortalama: {student.Average():0.##} - Sonuç: {result}");
        }

    }
}

class Lesson
{
    public string Name { get; set; }
    public int Matematik { get; set; }
    public int Fizik { get; set; }
    public int Kimya { get; set; }
    public int Biyoloji { get; set; }
    public int Tarih { get; set; }
    public int Cografya { get; set; }
    

    public double Average()
    {
        return (Matematik + Fizik + Kimya + Biyoloji + Tarih + Cografya) / 6.0;

        
    }
}
