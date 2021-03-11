using System;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-amer206-dykstra1] - This class will hold the data model for error

    public class ErrorViewModel
    {
        //tinfo200:[2021-03-11-amer206-dykstra1] - gets the information and then sets the values 
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
