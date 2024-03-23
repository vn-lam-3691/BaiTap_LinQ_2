using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    internal class Employee
    {
        public int employee_id { set; get; }
        public string employee_name { set; get; }
        public int employee_age { set; get; }
        public int department_id { set; get; }
        public int position_id { set; get; }

        public Employee()
        {
        }

        public Employee(int employee_id, string employee_name, int employee_age, int department_id, int position_id)
        {
            this.employee_id = employee_id;
            this.employee_name = employee_name;
            this.employee_age = employee_age;
            this.department_id = department_id;
            this.position_id = position_id;
        }

        public List<Employee> getEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Truong Van Lam", 26, 4, 1),
                new Employee(2, "Tran Cong Quang Phu", 21, 4, 2),
                new Employee(3, "Tran Lam Quoc Huy", 22, 3, 2),
                new Employee(4, "Pham Thanh Truc", 21, 1, 1),
                new Employee(5, "Le Phuoc Duc", 24, 2, 2),
                new Employee(6, "Phan Van Minh", 22, 2, 1),
                new Employee(7, "Tran Van Luong", 22, 3, 1),
                new Employee(8, "Pham Van Bao", 22, 4, 2)
            };
        }

        public override string ToString()
        {
            return "ID: " + employee_id + " - Name: " + employee_name + " - Age: " + employee_age + " - Department ID: " + department_id + " - Position ID: " + position_id;
        }
    }
}
