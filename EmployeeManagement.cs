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
            int checkAttendance = random.Next(0, 2);

            if (checkAttendance == Attendance_fulltime)
            {
                Console.WriteLine("Employee is present");
                employeeworkinghvrs = 8;
            }
            else if(checkAttendance == Attendance_parttime)
            {
                employeeworkinghvrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                employeeworkinghvrs = 0;
            }

            employeeonedaywage=employeeworkinghvrs*onehvrwage;
            Console.WriteLine("Employee wage="+employeeonedaywage);

        }
    }
}
