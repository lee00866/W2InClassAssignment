namespace W2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Point p = new Point(1, 2);
        // Console.WriteLine(p);
        
        Book book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        Console.WriteLine(book.DisplayInfo());
        
        Console.WriteLine();
        
        Student student = new Student();
        student.Name = "Eunji";
        student.Grade = 99;
        if (student.IsPassing())
        {
            Console.WriteLine("Student's name is "  + student.Name + ", grade is " + student.Grade + ".");
        }
        
        Console.WriteLine();
        
        Engine engine = new Engine(450);
        Car car = new Car("Mustang", engine);
        car.Describe();
        
        Console.WriteLine();

        Console.WriteLine(CountVowels("Hello World"));
        Console.WriteLine(CountVowels("Apples ARE awesome"));

    }

    static public int CountVowels(string input)
    {
        int count = 0;

        foreach (char c in input.ToLower())
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    count++;
                    break;
            }
        }
        return count;
        
    }
}