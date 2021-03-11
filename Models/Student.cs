using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-amer206-dykstra1] - This class will hold the data model for the Student information  
    public class Student
    {
        //tinfo200:[2021-03-11-amer206-dykstra1] - gets the information and then sets the values 
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
