using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class DoctorClass
    {
        public DoctorClass(int dId, string name, int age, string gender, string contactNum, string experience, string specialization)
        {
            DId = dId;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.contactNum = contactNum;
            this.experience = experience;
            this.specialization = specialization;
        }

        public void UpdateInfo(int dId, string name, int age, string gender, string contactNum, string experience, string specialization)
        {
            DId = dId;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.contactNum = contactNum;
            this.experience = experience;
            this.specialization = specialization;
        }

        public int DId;
        string name;
        int age;
        string gender;
        string contactNum;
        string experience;
        string specialization;
        string availability;
        string roomnumber;
        string floornumber;
        public int patientLoad = 0;

        public bool IncrementLoad()
        {
            if (patientLoad < 10)
            {
                patientLoad++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
