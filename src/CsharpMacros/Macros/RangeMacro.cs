﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CsharpMacros.Macros
{
    class RangeMacro:ICsharpMacro
    {
        private readonly Regex rangePattern = new Regex("\\s*(?<from>\\d+)\\s*,\\s*(?<to>\\d+)\\s*(,\\s*(?<step>\\d))*", RegexOptions.Compiled);

        public IEnumerable<Dictionary<string, string>> ExecuteMacro(string param, ICsharpMacroContext context)
        {
            var matchedRange = rangePattern.Match(param);
            if (matchedRange.Success)
            {
                var from = int.Parse(matchedRange.Groups["from"].Value);
                var to = int.Parse(matchedRange.Groups["to"].Value);
                var step = 1;
                if (matchedRange.Groups["step"].Success)
                {
                    step = Math.Max(int.Parse(matchedRange.Groups["step"].Value), 1);
                    if (from > to)
                    {
                        to = from;
                    }
                }

                for (int i = from; i <= to; i += step)
                {
                    yield return new Dictionary<string, string>()
                    {
                        ["index"] = i.ToString(),
                        ["from"] = from.ToString(),
                        ["to"] = to.ToString(),
                        ["step"] = step.ToString()
                    };
                }
            }
        }
    }
}