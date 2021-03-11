namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-amer206-dykstra1] - This allows the grade to be one of the following or null
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-11-amer206-dykstra1] - This class will hold the data model for the Enrollment informtion 
    public class Enrollment
    {
        //tinfo200:[2021-03-11-amer206-dykstra1] - gets the information and then sets the values 
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //tinfo200:[2021-03-11-amer206-dykstra1] - question marks makes it so it does not have to be A,B,C,D,F
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}