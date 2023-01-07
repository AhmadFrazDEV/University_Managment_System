using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4ProgramingDay.BL;
namespace Week4ProgramingDay.UI
{
    class student_UI
    {
      
       public static void ViewAllStudent(List<STUDENT> Student)
        {
            Console.WriteLine("Name \t \t FSC \t \t Ecat \t \t Age");
            for (int i = 0; i < Student.Count; i++)
            {
                if (Student[i].registeredProgram != null)
                {
                    Console.WriteLine(Student[i].getname() + "\t \t" + Student[i].getFscMarks() + "\t \t" + Student[i].getEcatMarks() + "\t \t" + Student[i].getage());
                }

            }
        }

      public  static void SpecificView(List<STUDENT> Student)
        {
            Console.Write("Enter the Degree: ");
            string name = Console.ReadLine();
            Clear();
            Console.WriteLine("Name \t \t FSC \t \t Ecat \t \t Age");
            for (int i = 0; i < Student.Count; i++)
            {
                for (int x = 0; x < Student[i].registeredProgram.Count; x++)
                {
                    if (name == Student[i].registeredProgram[x].getTitle())
                    {
                        Console.WriteLine(Student[i].getname() + "\t \t" + Student[i].getFscMarks() + "\t \t" + Student[i].getEcatMarks() + "\t \t" + Student[i].getage());
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

    }
}
