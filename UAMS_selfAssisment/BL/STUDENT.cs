using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week4ProgramingDay.BL
{
    class STUDENT
    {
        public STUDENT()
        {

        }
        public STUDENT(string Sname, int Sage, float Fsc, float Ecat, List<DegreeProgram> degree)
        {
            name = Sname;
            age = Sage;
            FscMarks = Fsc;
            EcatMarks = Ecat;
            newDegrees = degree;
        }


        private string name;
        private int age;
        private float FscMarks;
        private float EcatMarks;
        private float merit;
        public  List<DegreeProgram> newDegrees = new List<DegreeProgram>();
        public  List<DegreeProgram> registeredProgram = new List<DegreeProgram>();
        public  List<SUBJECT> registeredSubject = new List<SUBJECT>();


        public  string getname() { return name; }
        public void setname() { this.name = name; }

        public int  getage() { return age; }
        public void setage() { this.age = age; }

        public float getFscMarks() { return FscMarks; }
        public void setFscMarks() { this.FscMarks = FscMarks; }

        public float getEcatMarks() { return FscMarks; }
        public void setEcatMarks() { this.EcatMarks = EcatMarks; }

        public float getmerit() { return merit; }
        public void setmerit() { this.merit = merit; }



        public float CalculateMerit()
        {
            merit = FscMarks * 0.60F + EcatMarks * 0.40F;
            return merit;
        }

        public int calculateFee()
        {
            int fees = 0;
            for (int i = 0; i < registeredSubject.Count; i++)
            {
                fees = fees + registeredSubject[i].getsubjectFee();
            }
            return fees;
        }

        public int creditHourCalculator()
        {
            int creditHours = 0;
            for (int i = 0; i < registeredSubject.Count; i++)
            {
                creditHours = creditHours + registeredSubject[i].getcreditHours();
            }
            return creditHours;
        }
    }
}
