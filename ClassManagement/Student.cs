namespace ClassManagement;

public class Student
{
    private string fullname;
    private int id;
    private byte point;

    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string FullName
    {
        get
        {
            return fullname;
        }
        set
        {
            fullname = value;
        }
    }

    public Student(string fullname, int id, byte point)
    {
        FullName = fullname;
        this.id = id;
        this.point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"Student ID: {id}, Full Name: {FullName}, Point: {point}");
    }
}