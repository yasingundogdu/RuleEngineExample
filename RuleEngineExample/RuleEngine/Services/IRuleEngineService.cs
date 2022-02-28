using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.RuleEngine.Services
{
    internal interface IRuleEngineService<T> where T : class
    {
        string ProcessValidate(List<T> content, List<IValidateRule<T>> rules);
    }
}
