using System;

class GradeCalculator
{
    // Function to calculate the average of four subjects
    public double CalculateAverage(double maths, double physics,
                                   double chemistry, double computerScience)
    {
        return (maths + physics + chemistry + computerScience) / 4;
    }

    // Function to determine the grade
    public string CalculateGrade(double average)
    {
        if (average >= 80)
        {
            return "A";
        }
        else if (average >= 70)
        {
            return "B";
        }
        else if (average >= 60)
        {
            return "C";
        }
        else if (average >= 50)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Create an object of the GradeCalculator class
            GradeCalculator calculator = new GradeCalculator();

            // Get marks from the user
            Console.Write("Enter Maths marks (0-100): ");
            double maths = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Physics marks (0-100): ");
            double physics = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Chemistry marks (0-100): ");
            double chemistry = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Computer Science marks (0-100): ");
            double computerScience = Convert.ToDouble(Console.ReadLine());

            // Check that marks are between 0 and 100
            if (maths < 0 || maths > 100 ||
                physics < 0 || physics > 100 ||
                chemistry < 0 || chemistry > 100 ||
                computerScience < 0 || computerScience > 100)
            {
                Console.WriteLine("Invalid marks. Enter marks from 0 to 100.");
                return;
            }

            // Calculate the average
            double average = calculator.CalculateAverage(
                maths, physics, chemistry, computerScience);

            // Calculate the grade
            string grade = calculator.CalculateGrade(average);

            // Display the results
            Console.WriteLine("\nAverage marks: " + average.ToString("F2"));
            Console.WriteLine("Grade: " + grade);

            // Display a remark using a switch statement
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent! Your grade is A");
                    break;

                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;

                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;

                case "D":
                    Console.WriteLine("Pass. Your grade is D");
                    break;

                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;
            }
        }
        catch (FormatException)
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter numbers only.");
        }
        catch (Exception ex)
        {
            // Handle other errors
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
