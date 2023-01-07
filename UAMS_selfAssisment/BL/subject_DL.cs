using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
 using Week4ProgramingDay.BL;
namespace Week4ProgramingDay.BL
{
    class subject_DL
    {
        public static List<SUBJECT> subjectList = new List<SUBJECT>();
        public static void addSubjectIntoList(SUBJECT s)
        {
            subjectList.Add(s);
        }
        public static bool readData(string path)
        {
            StreamReader f = new StreamReader(path);
                string rec;
            if(File.Exists(path))
            {
                while((rec = f.ReadLine())!=null)
                {
                    string[] splittedRec = rec.Split(',');
                    string code = splittedRec[0];
                    string type = splittedRec[1];
                    int creditHours = int.Parse(splittedRec[2]);
                    int subjectFees = int.Parse(splittedRec[3]);
                    SUBJECT s = new SUBJECT(code, creditHours, type, subjectFees);
                    addSubjectIntoList(s);

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
