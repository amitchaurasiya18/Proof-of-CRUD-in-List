using ProofOfListCRUD.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // C -> Create Operation
        List<Student> students = new List<Student>();
        List<Professor> professors = new List<Professor>();

       
        students.Add(new Student(1, "Amit", "EXTC"));
        students.Add(new Student(2, "Abhishek", "CS"));
        students.Add(new Student(3, "Ruchika", "ECS"));
        students.Add(new Student(4, "Shreya", "IT"));

        professors.Add(new Professor(101, "Biju Balakrishnan", 50));
        professors.Add(new Professor(102, "Preeti Hemnani", 36));
        professors.Add(new Professor(103, "Pushkar Sathe", 32));
        professors.Add(new Professor(104, "Pranavi Nikkam", 33));


        // R -> Read Operation
        PrintLists(students, professors);

        // U -> Update Operation

        Console.WriteLine("\n\nUpdated Student details....");
        foreach (Student student in students)
        {
            if (student != null && student.Id == 1)
            {
                Console.Write($"Enter new Student Name: ");
                student.Name = Console.ReadLine();

                Console.Write($"Enter new Student Branch: ");
                student.Branch = Console.ReadLine();
            }

            Console.WriteLine($"{student.Id} => {student.Name} => {student.Branch}");
        }

        Console.WriteLine("\n\nUpdated Professor details....");
        foreach (Professor professor in professors)
        {
            if (professor != null && professor.Id == 104)
            {
                Console.Write($"Enter new Professor Name: ");
                professor.Name = Console.ReadLine();

                Console.Write($"Enter new Professor Branch: ");
                professor.Age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{professor.Id} => {professor.Name} => {professor.Age}");
        }


        // D -> Delete Operation

        students.RemoveAt(1);
        professors.RemoveAt(2);

        PrintLists(students, professors);
    }

    public static void PrintLists(List<Student> students, List<Professor> professors)
    {
        Console.WriteLine("List of Students\n");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} => {student.Name} => {student.Branch}");
        }

        Console.WriteLine("\nList of Professors\n");
        foreach (var professor in professors)
        {
            Console.WriteLine($"{professor.Id} => {professor.Name} => {professor.Age}");
        }
    }
}