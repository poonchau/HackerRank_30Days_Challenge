using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
    {
        testScores = new int[scores.Length];
        for (int i = 0; i < scores.Length; i++)
        {
            testScores[i] = scores[i];
        }
    }
    /*  
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
   public char Calculate()
    {
        int total = 0;
        for (int i = 0; i < testScores.Length; i++)
        {
            total = total + testScores[i];
        }

        int avg;
        // avg = Convert.ToInt32(Math.Floor(total / testScores.Length));
        avg = (total / testScores.Length);

        if (avg >= 90 || avg <= 100)
        {
            return 'O';
        }

        else if (avg >= 80 || avg <= 90)
        {
            return 'E';
        }

        else if (avg >= 70 || avg <= 80)
        {
            return 'A';
        }

        else if (avg >= 55 || avg <= 70)
        {
            return 'P';
        }

        else if (avg >= 40 || avg <= 55)
        {
            return 'D';
        }

        else if (avg < 40)
        {
            return 'T';
        }
        return 'F';
    }


}

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Trim().Split(' ');
        if (inputs.Length > 2)
        {
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Please Provide correct input string with firstname,secondname ,Id");
        }
    }
}