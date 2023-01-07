using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4ProgramingDay.BL;
using Week4ProgramingDay.DL;
using Week4ProgramingDay.UI;

namespace Week4ProgramingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            List<DegreeProgram> Degree = new List<DegreeProgram>();
            List<STUDENT> Student = new List<STUDENT>();
            do
            {
                header();
                op = menu();
                Clear();
                if (op == '1')
                {
                  
                    header();
                    Student.Add(student_DL.AddStudent(Degree));
                    Clear();
                }
                else if (op == '2')
                {
                    
                    header();
                    Degree.Add(degreeProgram_DL.AddDegree());
                    Clear();
                }
                else if (op == '3')
                {
                    
                    header();
                    student_DL.GenerateMerit(Student, Degree);
                    Clear();
                }
                else if (op == '4')
                {
                   
                    header();
                    student_UI.ViewAllStudent(Student);
                    Clear();
                }
                else if (op == '5')
                {
                    
                    header();
                    student_UI.SpecificView(Student);
                    Clear();
                }
                else if (op == '6')
                {
                    header();
                    degreeProgram_DL.AddregisteredSubject(Student);
                    Clear();
                }
                else if (op == '7')
                {
                    header();
                    degreeProgram_DL.calculateFees(Student);
                    Clear();
                }
            }
            while (op != '8');
        }
        static void header()
        {
            Console.WriteLine("==================> UAMS <====================");
          
        }
        static char menu()
        {
            char op;
            Console.WriteLine("1. Add Student.");
            Console.WriteLine("2. Add Degree Program.");
            Console.WriteLine("3. Generate Merit.");
            Console.WriteLine("4. View Registered Students.");
            Console.WriteLine("5. View Students of a Specific Program.");
            Console.WriteLine("6. Register Subjects for a Specfic Program.");
            Console.WriteLine("7. Calculate Fees for all Registered Students.");
            Console.WriteLine("8. Exit");
            Console.Write("Your Option ------> ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        static void Clear()
        {
            Console.WriteLine("Press any key button to continue");
            Console.ReadKey();
            Console.Clear();
        }
        
        
        
       
        

    }
}
