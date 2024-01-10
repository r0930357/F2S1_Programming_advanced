using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.Models
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
        public Publisher publiser { get; set; }
        public string fullName => $"{firstName} {lastName}";
        public override string ToString()
        {
            return fullName;
        }
    }
}