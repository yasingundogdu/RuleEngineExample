using RuleEngineExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine.Rules
{
    public class MilitaryServiceRule : IValidateRule<Employee>
    {
        public MilitaryServiceRule()
        {

        }
        public string Evaluate(List<Employee> content)
        {
            if (content.Where(q=>q.Gender == GenderEnum.Male.ToString()).Any(q => !q.MilitaryService))
                return "Failed: MilitaryServiceRule";

            return "Success";
        }

        public bool ShouldRun(List<Employee> content)
        {
            if (content.Any(q=>q.Gender == GenderEnum.Male.ToString()))
                return true;
            return false;
        }
    }
}

