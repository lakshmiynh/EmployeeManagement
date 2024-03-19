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

            int Attendance_fulltime = 2;
            int Attendance_parttime = 1;

            int onehvrwage = 20;

            int employeeworkinghvrs = 0;
            int employeeonedaywage = 0;

            Random random = new Random();

            // check present or absent
            int checkAttendance = random.Next(0, 3);

            switch(checkAttendance)
            {
                case 1: employeeworkinghvrs = 4; // parttime 
                    break;

                case 2:employeeworkinghvrs = 8; // fulltime
                    break;

                default:employeeworkinghvrs= 0;
                    break;

            }

            employeeonedaywage=employeeworkinghvrs*onehvrwage;
            Console.WriteLine("Employee wage="+employeeonedaywage);

        }
    }
}
