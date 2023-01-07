using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4ProgramingDay.BL;
namespace Week4ProgramingDay.DL
{
    class degreeProgram_DL
    {
        public static DegreeProgram AddDegree()
        {
            DegreeProgram newDegree = new DegreeProgram();
            Write("Enter Degree Name: ");
            string newTitle = ReadLine();
            newDegree.setTitle(newTitle);
            Write("Enter Degree Duration: ");
            int newdue = int.Parse(ReadLine());
            newDegree.setDuration(newdue);
            Write("Enter Seats for Degree: ");
            int newSeats = int.Parse(ReadLine());
            newDegree.setSeats(newSeats);
            Console.WriteLine("Enter how many subjects to Enter: ");
            int NumOfSubject = int.Parse(Console.ReadLine());
            SUBJECT temp = new SUBJECT();
            int creditHrs = 0;
            for (int i = 0; i < NumOfSubject; i++)
            {

                temp = newDegree.addSubject();
                creditHrs = temp.getcreditHours() + newDegree.creditHourCalculator();
                if (creditHrs <= 20)
                {
                    newDegree.newSubjects.Add(temp);
                }
                else
                {
                    Console.WriteLine("Credit hours limit exceeded");
                    break;
                }
            }
            return newDegree;
        }

       public static void AddregisteredSubject(List<STUDENT> Student)
        {
            Console.Write("Enter Student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Subject code: ");
            string code = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < Student.Count; i++)
            {
                for (int x = 0; x < Student[i].registeredProgram.Count; x++)
                {
                    for (int y = 0; y < Student[i].registeredProgram[x].newSubjects.Count; y++)
                    {
                        if (name == Student[i].getname() && code == Student[i].registeredProgram[x].newSubjects[y].getsubjectType())
                        {
                            int creditHours = Student[i].creditHourCalculator() + Student[i].registeredProgram[x].newSubjects[y].getcreditHours();
                            if (creditHours <= 9)
                            {
                                Student[i].registeredSubject.Add(Student[i].registeredProgram[x].newSubjects[y]);
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Credit Hour Limit Exceeded");
                                break;
                            }

                        }

                    }

                }
            }
            if (count == 0)
            {
                Console.WriteLine("wrong input");
            }
        }

        public static void calculateFees(List<STUDENT> Student)
        {
            for (int i = 0; i < Student.Count; i++)
            {
                Console.WriteLine(Student[i].getname() + " has " + Student[i].calculateFee() + " fee");
            }
        }
    }
}
