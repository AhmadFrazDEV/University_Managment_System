using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4ProgramingDay.BL;
using Week4ProgramingDay.DL;
using Week4ProgramingDay.UI;
namespace Week4ProgramingDay.DL
{
    class student_DL
    {
        public static STUDENT AddStudent(List<DegreeProgram> Degree)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            float FscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            float EcatMarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Available Degree Programs");
            for (int i = 0; i < Degree.Count; i++)
            {
                Console.WriteLine(Degree[i].getTitle());
            }

            Console.Write("Enter how many preferences to Enter: ");
            int NumOFPreference = int.Parse(Console.ReadLine());
            List<DegreeProgram> newdegree = new List<DegreeProgram>();
            for (int i = 0; i < NumOFPreference; i++)
            {
                string newTemp = Console.ReadLine();
                DegreeProgram temp = new DegreeProgram();
                
                int count = 0;
                for (int x = 0; x < Degree.Count; x++)
                {
                    if (temp.getTitle() == Degree[x].getTitle())
                    {
                        newdegree.Add(temp);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Wrong input");
                }
            }
            STUDENT newStudent = new STUDENT(name, age, FscMarks, EcatMarks, newdegree);

            return newStudent;
        }

        public static void GenerateMerit(List<STUDENT> Student, List<DegreeProgram> Degree)
        {
            DegreeProgram std = new DegreeProgram();
            sort(Student);
            for (int i = 0; i < Student.Count; i++)
            {
                for (int j = 0; j < Student[i].newDegrees.Count; j++)
                {
                    if (Student[i].newDegrees[j].getTitle() == Degree[i].getTitle() && Degree[i].getSeats() > 0)
                    {
                        Console.WriteLine(Student[i].getname() + " got Admission in " + Student[i].newDegrees[j].getTitle());
                        Student[i].registeredProgram.Add(Degree[i]);
                        int s =Degree[i].getSeats();
                        s--;
                        std.setSeats(s);

                    }
                    else
                    {
                        Console.WriteLine(Student[i].getname() + " did not get Admission");
                    }
                }
            }
        }

        public static void sort(List<STUDENT> student)
        {
            List<STUDENT> studentList = new List<STUDENT>();
            List<STUDENT> sortedList = studentList.OrderBy(o => o.getmerit()).ToList();
            }
        }

    }

