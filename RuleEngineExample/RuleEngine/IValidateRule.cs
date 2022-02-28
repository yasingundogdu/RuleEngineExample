using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine
{
    public interface IValidateRule<T> where T : class
    {
        string Evaluate(List<T> content);
        bool ShouldRun(List<T> content);

    }
}
