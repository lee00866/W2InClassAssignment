public class Student
{
    private string name;
    private int grade;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Grade
    {
        get { return grade; }
        set
        {
            if (value is < 0 or > 100)
            {
                Console.WriteLine("The grade can only be between 0 and 100.");
            }
            else
            {
                grade = value;
            }
        }
    }

    public bool IsPassing()
    {
        if (grade >= 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}