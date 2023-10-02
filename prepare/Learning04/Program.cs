using System;

namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            var assignment = new Assignment("Brent M. Cross", "History");
            Console.WriteLine(assignment.GetSummary());

            var mathAssignment = new MathAssignment("Jessica Cross", "Mulitiplication", "Section 9", "10-11");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());

            var writingAssignment = new WritingAssignment("Margie Cross", "American History", "The Causes of Civil War");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }
}
