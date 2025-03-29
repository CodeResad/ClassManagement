namespace ClassManagement;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group("AB123", 10);
        
        Student student1 = new Student("John Doe", 1, 85);
        Student student2 = new Student("Jane Smith", 2, 90);
        
        group.AddStudent(student1);
        group.AddStudent(student2);
        
        Console.WriteLine(group.CheckGroupNo("AB109"));
        
        Console.WriteLine("All students in group:");
        foreach (Student student in group.GetAllStudents())
        {
            student.StudentInfo();
        }
    }
}