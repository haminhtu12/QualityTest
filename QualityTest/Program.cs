using QualityTest.Controllers;
using QualityTest.Models;
using System;
using System.Text;

namespace QualityTest
{
    class Program:StudentController
    {
        static void Main(string[] args)
        {
           
            GenerateMenu();
        }
         public static void GenerateMenu()
        {
            var stc = new StudentController();
            while (true)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;
                Console.WriteLine("Nhập lựa chọn của bạn ");
                Console.WriteLine("=====================");
                Console.WriteLine("Menu");
                Console.WriteLine("=====================");
                Console.WriteLine("1 -Tạo Mới Sinh Viên");
                Console.WriteLine("2 -Hiển Thị Danh Sách Sinh Viên");
                Console.WriteLine("3 -EXIT");

                int choice = Convert.ToInt32(Console.ReadLine());
                while (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ  vui lòng chọn lại");
                    Console.WriteLine("=====================");
                    Console.WriteLine("Menu");
                    Console.WriteLine("=====================");
                    Console.WriteLine("1 -Tạo Mới Sinh Viên");
                    Console.WriteLine("2 -Hiển Thị Danh Sách Sinh Viên");
                    Console.WriteLine("3 -EXIT");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
               
                switch (choice)
                {
                    case 1:
                        stc.CreateStudent();
                        break;
                    case 2:
                       
                        stc.PrintListStudent(stc.student);
                        break;
                    default:
                        System.Environment.Exit(0);

                        break;
                }



            }


        }
    }
}
