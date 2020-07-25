using System;
using System.Collections.Generic;
using System.Text;

namespace QualityTest.Models
{
    class Student
    {

        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }

        bool IsNewStudent()
        {
            return CreatedAt >= DateTime.Now.AddMonths(-2); ;
        }
        bool IsDeactive()
        {
            return Status == StudentStatus.DEACTIVE;
        }
        public enum StudentStatus
        {
            ACTIVE = 1,
            DEACTIVE = 0,
        }

    }
}
