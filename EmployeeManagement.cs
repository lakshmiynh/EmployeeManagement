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
        
         
        public int CalculateEmployeewage(string company,int employeewageperhvr,int workingdays,int maxhvrspermonth)
        {

            int employeeworkinghvrs = 0;
            int employeeonedaywage = 0;
            int employeetotalwage = 0;
            int employeetotalworkingdays = 0;
            int employeetotalworkinghvrs = 0;




            while (employeetotalworkingdays <= workingdays && employeetotalworkinghvrs <= maxhvrspermonth)
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

                Console.WriteLine("days:" + employeetotalworkingdays + "hrs:" + employeeworkinghvrs);


            }

            employeetotalwage = employeetotalworkinghvrs * employeewageperhvr;

            Console.WriteLine("Employee total  wage=" +company+"is="+ employeetotalwage);
            return employeetotalwage;
        }
        static void Main(String[] args)
        {
            EmployeeManagement obj=new EmployeeManagement();
            obj.CalculateEmployeewage("vishalmart",30,2,10);
            obj.CalculateEmployeewage("KMF", 40, 2, 20);


        }
    }
}
