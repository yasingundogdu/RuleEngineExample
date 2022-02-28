using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine
{
    public class RuleEngine<T> where T : class
    {
        private readonly List<IValidateRule<T>> _rules;
        public RuleEngine(List<IValidateRule<T>> rules)
        {
            _rules = rules;
        }
        public string Validate(List<T> content)
        {
            string response = "";

            foreach (var rule in _rules)
            {
                if (rule.ShouldRun(content))
                    response = rule.Evaluate(content);

                if (String.IsNullOrWhiteSpace(response))
                    break;
            }

            return response;
        }

    }
}
