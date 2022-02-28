using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.Models
{
    public class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
        public string Seniority { get; set; }
        public string Gender { get; set; }
        public bool MilitaryService { get; set; }
    }

    public enum SeniorityEnum
    {
        Jr = 0,
        Mid = 1,
        Sr = 2
    }

    public enum GenderEnum
    {
        Male = 0,
        Female = 1
    }
}
