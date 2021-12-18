using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core.Abstractions
{
    public abstract class Parser : ErrorCollector
    {
        public bool TryParse(string input, Action failAction)
        {
            if (!TryParse(input))
            {
                failAction();
                return false;
            }
            return true;
        }

        public abstract bool TryParse(string input);
    }
}
