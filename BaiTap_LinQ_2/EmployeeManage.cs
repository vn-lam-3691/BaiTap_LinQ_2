using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    internal class EmployeeManage
    {
        private Position positions = new Position();
        private Department departments = new Department();
        private Employee employees = new Employee();

        public EmployeeManage()
        {
        }

        public IEnumerable<Employee> findEmployeesByRangeAge(int start, int end)
        {
            return employees.getEmployees().Where(e => e.employee_age >= start && e.employee_age <= end);
        }

        public IEnumerable<Department> findDepartment(string department_name)
        {
            return departments.getDepartments().Where(d => d.department_name.Contains(department_name));
        }

        public IEnumerable<Position> findPosition(string position_name)
        {
            return positions.getPositions().Where(p => p.position_name.Contains(position_name));
        }

        public IEnumerable<Employee> findEmployeesByName(string name)
        {
            return employees.getEmployees().Where(e => e.employee_name.Contains(name));
        }

        public void findEmployeesByKeyword(string keyword)
        {
            var result = from e in employees.getEmployees()
                         join d in departments.getDepartments() on e.department_id equals d.department_id
                         join p in positions.getPositions() on e.position_id equals p.position_id
                         where e.employee_name.Contains(keyword) || d.department_desc.Contains(keyword) || p.position_desc.Contains(keyword)
                         select new
                         {
                             e.employee_id,
                             e.employee_name,
                             e.employee_age,
                             d.department_desc,
                             p.position_desc  
                         };

            foreach (var item in result)
            {
                Console.WriteLine("ID: " + item.employee_id + " - Name: " + item.employee_name + " - Age: " + item.employee_age + " - Department: " + item.department_desc + " - Position: " + item.position_desc);
            }
        }

        //public IEnumerable<T> findEmployeesByKeyword<T>(string name)
        //{
        //    return (IEnumerable<T>)employees.Where(e => e.employee_name.Contains(name));
        //}

        public void displayEmployees<T>(IEnumerable<T> result)
        {
            if (result != null && result.GetEnumerator().MoveNext())
            {
                foreach (var item in result)
                {
                    if (item is Employee)
                    {
                        Console.WriteLine(item);
                    }
                    else if (item is Department)
                    {
                        Console.WriteLine(item);
                    }
                    else if (item is Position)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay ket qua phu hop");
            }
        }

        public void showAllEmployee()
        {
            foreach (Employee e in employees.getEmployees())
            {
                Console.WriteLine(e);
            }
        }
    }
}
