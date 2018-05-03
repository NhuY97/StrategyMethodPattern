using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy.Strategy
{
    public interface StrategyConverter
    {
        decimal doConvert(decimal input);
    }
}
