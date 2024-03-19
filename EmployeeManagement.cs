using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{

   
    class EmployeeManagement
    {

        public const int Attendance_fulltime = 2;
        public const int Attendance_parttime = 1;
        public const int onehvrwage = 20;
        public const int onemonth_workingdays = 20; // working days for one month
        public const int onemonth_workinghvrs = 100;
         
        public void CalculateEmployeewage()
        {

            int employeeworkinghvrs = 0;
            int employeeonedaywage = 0;
            int employeetotalwage = 0;
            int employeetotalworkingdays = 0;
            int employeetotalworkinghvrs = 0;




            while (employeetotalworkingdays <= onemonth_workingdays && employeetotalworkinghvrs <= onemonth_workinghvrs)
            {
                Random random = new Random();

                // check present or absent
                int checkAttendance = random.Next(0, 3);

                employeetotalworkingdays++;

                switch (checkAttendance)
                {
                    case 1:
                        employeeworkinghvrs = 4; // parttime 

                        break;

                    case 2:
                        employeeworkinghvrs = 8; // fulltime
                        break;

                    default:
                        employeeworkinghvrs = 0;
                        break;

                }
                employeetotalworkinghvrs = employeetotalworkinghvrs + employeeworkinghvrs;




            }

            employeetotalwage = employeetotalworkinghvrs * onehvrwage;

            Console.WriteLine("Employee one month wage=" + employeetotalwage);

        }
        static void Main(String[] args)
        {
            EmployeeManagement obj=new EmployeeManagement();
            obj.CalculateEmployeewage();



        }
    }
}
