using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public static class GlobalVars
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
        
        static List<DoctorClass> doctors = new List<DoctorClass>();

        public static void Record(DoctorClass doc)
        {
            doctors.Add(doc);
        }

        public static bool CheckLoad(int specId)
        {
            foreach (DoctorClass doc in doctors)
            {
                if (doc.DId == specId)
                {
                    return doc.IncrementLoad(); //Increment patient load by 1 and return true if patient load < 10
                }
            }
            return false; //Return false in case there are no doctors or patient load is too much
        }

        public static DoctorClass FindDoctor(int specId)
        {
            foreach (DoctorClass doc in doctors)
            {
                if (doc.DId == specId)
                {
                    return doc; //Increment patient load by 1 and return true if patient load < 10
                }
            }
            return null;
        }
    }
}
