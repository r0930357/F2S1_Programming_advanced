using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int? jobId { get; set; }
        public int? jobLevel { get; set; }
        public int publisherId { get; set; }
        public DateTime hireDate { get; set; }
        public string fullName => $"{firstName} {lastName}";
        public Publisher Publisher { get; set; }
        public Job Job { get; set; }
    }
}
