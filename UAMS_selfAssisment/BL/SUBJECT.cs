using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ProgramingDay.BL
{
    class SUBJECT
    {
        public SUBJECT()
        {

        }
        private string code;
        private int creditHours;
        private string subjectType;
        private int subjectFee;

        public SUBJECT(string code , int creditHours , string subjectType , int subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }

        public string getCode() { return code; }
        public void setCode(string code) { this.code = code;  }

        public int getcreditHours() { return creditHours; }
        public void setcreditHours(int creditHours) { this.creditHours = creditHours; }

        public string getsubjectType() { return subjectType; }
        public void setsubjectType(string subjectType) { this.subjectType = subjectType; }

        public int getsubjectFee() { return subjectFee; }
        public void setsubjectFee(int subjectFee) { this.subjectFee = subjectFee; }
    }
}
