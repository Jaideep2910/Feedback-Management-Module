using System;

namespace studentfeedback.Models
{
    public class feedback
    {
        public int EnrollNo { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int rating { get; set; }
        public string comments { get; set; }
    }
}
