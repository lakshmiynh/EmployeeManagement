using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    class EmployeeManagement
    {
        static void Main(String[] args)
        {

            int Attendance = 1;
            

            

            Random random = new Random();

            //computation
            int checkAttendance = random.Next(0, 2);

            if (checkAttendance == Attendance)
            {
                Console.WriteLine("Employee is present");
                
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
