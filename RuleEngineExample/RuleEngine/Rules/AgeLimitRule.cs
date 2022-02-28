using RuleEngineExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine.Rules
{
    public class AgeLimitRule : IValidateRule<Employee>
    {
        public AgeLimitRule()
        {

        }
        public string Evaluate(List<Employee> content)
        {
            if (content.Any(q => q.Age < 18))
                return "Failed: AgeLimitRule";

            return  "Success";
        }

        public bool ShouldRun(List<Employee> content)
        {
            return true;
        }
    }
}

