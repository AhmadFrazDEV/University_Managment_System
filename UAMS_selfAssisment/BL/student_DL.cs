using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ProgramingDay.BL
{
    class student_DL
    {
        public static List<DegreeProgram> prefrence = new List<DegreeProgram>();
        public static void addSubjectIntoList(SUBJECT s)
        {
            prefrence.Add(s);
        }
        public static bool readData(string path)
        {
            StreamReader f = new StreamReader(path);
            string rec;
            if (File.Exists(path))
            {
                while ((rec = f.ReadLine()) != null)
                {
                    string[] splitRec = rec.Split(',');
                    string name = splitRec[0];
                    int age = splitRec[1];
                    float fscMarks = splitRec[2];
                    float ecatMarks = splitRec[3];
                    string[] splitRecForPrefrence = splitRec[4].Split(';');

                    for(int i=0; splitRecForPrefrence.Length; i++)
                    {
                        DegreeProgram d = DegreeProgram_DL.degreeExist(splitRecForPrefrence[i]);
                    }

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
