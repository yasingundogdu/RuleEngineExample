using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine.Services
{
    public class RuleEngineService<T> : IRuleEngineService<T> where T : class
    {
        public string ProcessValidate(T content, List<IValidateRule<T>> rules)
        {
            var engine = new RuleEngine<T>(rules);
            return engine.Validate(new List<T> { content });
        }
        public string ProcessValidate(List<T> content, List<IValidateRule<T>> rules)
        {
            var engine = new RuleEngine<T>(rules);
            return engine.Validate(content);
        }
    }
}
