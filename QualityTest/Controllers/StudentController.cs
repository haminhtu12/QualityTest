using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityTest.Controllers
{
    class StudentController : Student
    {
       public  List<Student> student = new List<Student>();
        public Student PrintListStudent(List<Student> student)
        {
          
            foreach (Student st in student)
            {
                Console.WriteLine("(Mã số sinh viên :"      + st.RollNumber);
                Console.WriteLine("Tên  sinh viên :"        + st.FullName);
                Console.WriteLine("Ngày sinh :"             + st.Birthday);
                Console.WriteLine("Email  :"                + st.Email);
                Console.WriteLine("Số điện thoại   :"       + st.Phone);
                Console.WriteLine("Ngày nhập học  :"        + st.CreatedAt);
                Console.WriteLine("Trạng thái sinh viên  :" + st.Status);
            }
            return new Student();
        }
        public Student CreateStudent()
        {
            Student st = new Student();

            try
            {
               
                Console.WriteLine("Nhập Mã số sinh viên ");
                st.RollNumber = Console.ReadLine();
                Console.WriteLine("Nhập Tên đầy đủ ");
                st.FullName = Console.ReadLine();
                Console.WriteLine("Nhập Ngày sinh ");
                st.Birthday = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhập Email ");
                st.Email = Console.ReadLine();
                Console.WriteLine("Nhập Số Điện Thoại ");
                st.Phone = Console.ReadLine();
                Console.WriteLine("Nhập Trạng thái sinh viên ACTIVE or DEACTIVE");
                string status = Console.ReadLine();
                while(status != "ACTIVE" && status != "DEACTIVE")
                {
                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại");
                     status = Console.ReadLine();

                }
                st.Status = (StudentStatus)Enum.Parse(typeof(StudentStatus), status);
                student.Add(st);
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong."+e);
            }

            return st;

        }
    }
}
