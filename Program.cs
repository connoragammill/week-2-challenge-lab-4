namespace week_2_challenge_lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            Console.WriteLine("Input the Roll Number of the student:"); 
            student.RollNo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input the Name of the Student:"); 
            student.Name = Console.ReadLine(); 
            
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application:"); 
            student.PhysicsMarks = int.Parse(Console.ReadLine()); 
            student.ChemistryMarks = int.Parse(Console.ReadLine()); 
            student.CompAppMarks = int.Parse(Console.ReadLine()); 

            // Calculate total marks, percentage and division
            int totalMarks = student.CalculateTotalMarks(); 
            double percentage = student.CalculatePercentage(); 
            string division = student.DetermineDivision(); 
            
            Console.WriteLine($"Roll No: {student.RollNo}"); 
            Console.WriteLine($"Name of Student: {student.Name}"); 
            Console.WriteLine($"Marks in Physics: {student.PhysicsMarks}"); 
            Console.WriteLine($"Marks in Chemistry: {student.ChemistryMarks}"); 
            Console.WriteLine($"Marks in Computer Application: {student.CompAppMarks}"); 
            Console.WriteLine($"Total Marks = {totalMarks}"); 
            Console.WriteLine($"Percentage = {percentage:F2}"); 
            Console.WriteLine($"Division = {division}");
        }
        public class Student
        { 
            public int RollNo { get; set; } 
            public string Name { get; set; } 
            public int PhysicsMarks { get; set; } 
            public int ChemistryMarks { get; set; } 
            public int CompAppMarks { get; set; } 
            
            public int CalculateTotalMarks() 
            { 
                return PhysicsMarks + ChemistryMarks + CompAppMarks; 
            } 
            public double CalculatePercentage() 
            { 
                return (CalculateTotalMarks() / 3.0); 
            } 
            public string DetermineDivision() 
            { 
                //If the percentage of the grades is above 60 or more, display First
                double percentage = CalculatePercentage(); 
                if (percentage >= 60) 
                    return "First";
                //If the percentage of the grades is in the 50's, display Second
                else if (percentage >= 50) 
                    return "Second";
                //If the percentage of the grades is in the 40's, display Third
                else if (percentage >= 40) 
                    return "Third";
                //If the percentage of the grades is lower than 40, display Fail
                else
                    return "Fail"; 
            } 
        }
        
    }
}
