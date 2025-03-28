using System.Text.RegularExpressions;

namespace ClassManagement;

public class Group
{
    private string groupNo;
    private byte studentLimit;
    private Student[] students;

    public byte StudentLimit
    {
        get
        {
            return studentLimit;
        }
        set
        {
            if (value >= 5 && value <= 18)
            {
                studentLimit = value;
            }
            else
            {
                Console.WriteLine("Student limit must be between 5 and 18!!!");
            }
        }
    }

    public Group(string groupNo, byte studentLimit)
    {
        this.groupNo = groupNo;
        StudentLimit = studentLimit;
        students = new Student[0];
    }

    public bool CheckGroupNo(string GroupNo)
    {
        if (GroupNo.Length != 5)
        {
            return false;
        }
        
        for (int i = 0; i < 2; i++)
        {
            if (!char.IsUpper(GroupNo[i]))
                return false;
        }
        
        for (int i = 2; i < 5; i++)
        {
            if (!char.IsDigit(GroupNo[i]))
                return false;
        }
        
        return true;
    }

    public void AddStudent(Student student)
    {
        if (students.Length < StudentLimit)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        else
        {
            Console.WriteLine("You exceeded the limit!!!");
        }
    }

    public Student GetStudent(int id)
    {
        foreach (Student s in students)
        {
            if (s.ID == id)
            {
                return s;
            }
        }
        return null;
    }

    public Student[] GetAllStudents()
    {
        return students;
    }
    


}