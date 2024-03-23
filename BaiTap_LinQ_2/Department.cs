using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    internal class Department
    {
        public int department_id { set; get; }
        public string department_name { set; get; }
        public string department_desc { set; get; }

        public Department()
        {
        }

        public Department(int department_id, string department_name, string description)
        {
            this.department_id = department_id;
            this.department_name = department_name;
            this.department_desc = description;
        }

        public List<Department> getDepartments()
        {
            return new List<Department>
            {
                new Department(1, "Phong ke toan", "Phong ke toan"),
                new Department(2, "Phong nhan su", "Phong nhan su"),
                new Department(3, "Phong kinh doanh", "Phong kinh doanh"),
                new Department(4, "Phong IT", "Phong IT")
            };
        }

        public override string ToString()
        {
            return "ID: " + department_id + " - Name: " + department_name + " - Description: " + department_desc;
        }
    }
}
