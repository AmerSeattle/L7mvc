﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-amer206-dykstra1] - This class will hold the data model for the Course 
    public class Course
    {
        //tinfo200:[2021-03-11-amer206-dykstra1] - This statement is used so that the Course ID  is not 
        //tinfo200:[2021-03-11-amer206-dykstra1] - generated by the database. Dont create a value for each 
        //tinfo200:[2021-03-11-amer206-dykstra1] - gets the information and then sets the values 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
