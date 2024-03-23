using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    internal class Program
    {
        static EmployeeManage employeeManage = new EmployeeManage();

        static void Main(string[] args)
        {
            char k = 'y';
            while (k == 'y' || k == 'Y')
            {
                Menu();
                Console.WriteLine("Ban co muon tiep tuc khong? (Y/N)");
                k = char.Parse(Console.ReadLine());
            }
        }

        static void Menu()
        {
            Console.WriteLine("----- MENU THAO TAC -----");
            Console.WriteLine("1. Hien thi danh sach nhan vien");
            Console.WriteLine("2. Tim kiem nhan vien theo ten");
            Console.WriteLine("3. Tim kiem nhan vien theo do tuoi");
            Console.WriteLine("4. Tim kiem nhan vien theo phong ban");
            Console.WriteLine("5. Tim kiem nhan vien theo vi tri cong viec");
            Console.WriteLine("6. Tim kiem bang tu khoa:");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch(chon)
            {
                case 1:
                    employeeManage.showAllEmployee();
                    break;
                 case 2:
                    Console.WriteLine("Nhap ten nhan vien can tim: ");
                    string name = Console.ReadLine();
                    var result = employeeManage.findEmployeesByName(name);
                    employeeManage.displayEmployees(result);
                    break;
                case 3:
                    Console.WriteLine("Nhap do tuoi nhan vien can tim: ");
                    Console.Write("Tu: ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write("Den: ");
                    int end = int.Parse(Console.ReadLine());
                    var result1 = employeeManage.findEmployeesByRangeAge(start, end);
                    employeeManage.displayEmployees(result1);
                    break;
                case 4:
                    Console.WriteLine("Nhap ten phong ban can tim: ");
                    string departmentName = Console.ReadLine();
                    var result2 = employeeManage.findDepartment(departmentName);
                    employeeManage.displayEmployees(result2);
                    break;
                case 5:
                    Console.WriteLine("Nhap ten vi tri cong viec can tim: ");
                    string positionName = Console.ReadLine();
                    var result3 = employeeManage.findPosition(positionName);
                    employeeManage.displayEmployees(result3);
                    break;
                case 6:
                    Console.WriteLine("Nhap tu khoa can tim: ");
                    string keyword = Console.ReadLine();
                    employeeManage.findEmployeesByKeyword(keyword);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
