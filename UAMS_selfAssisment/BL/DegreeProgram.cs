using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ProgramingDay.BL
{
    class DegreeProgram
    {
        public DegreeProgram()
        {

        }
        private string title;
        private int duration;
        private int availableSeats;
        public List<SUBJECT> newSubjects = new List<SUBJECT>();

        public DegreeProgram(string title , int duration , int availableSeats)
        {
            this.title = title;
            this.duration = duration;
            this.availableSeats = availableSeats;
        }

      public string getTitle() { return title; }
        public void setTitle(string title) { this.title = title; }

        public int getSeats() { return availableSeats; }
        public void setSeats(int availableSeats) { this.availableSeats = availableSeats; }

        public int getDuration() { return duration; }
        public void setDuration(int duration) { this.duration = duration; }

        public SUBJECT addSubject()
        {
            SUBJECT newSubject = new SUBJECT();
            WriteLine("Enter Subject Code: ");
            string newCode = ReadLine();
            newSubject.setCode(newCode);
            WriteLine("Enter Subject Type: ");
            string newSub = ReadLine();
            newSubject.setsubjectType(newSub);
            WriteLine("Enter Subject Credit Hours");
            int newCredit = int.Parse(ReadLine());
            newSubject.setcreditHours(newCredit);
            WriteLine("Enter the Subject Fees: ");
            int newFee = int.Parse(ReadLine());
            newSubject.setsubjectFee(newFee);
            return newSubject;
        }
        public int creditHourCalculator()
        {
            int creditHours = 0;
            for (int i = 0; i < newSubjects.Count; i++)
            {
                creditHours = creditHours + newSubjects[i].getcreditHours();
            }
            return creditHours;
        }
    }
}
