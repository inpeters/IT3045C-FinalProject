using System;

namespace IT3045C_FinalProject.Models
{

    public class Member
    {
        public int? ID { get; set; }

        public string FullName { get; set; }

        public string CollegeProgram { get; set; }

        public string YearInProgram { get; set; }

        public DateTime Birthdate { get; set; }
    }

}