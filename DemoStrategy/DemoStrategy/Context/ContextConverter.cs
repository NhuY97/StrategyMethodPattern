using DemoStrategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy.Context
{
    public class ContextConverter
    {
        private StrategyConverter strategyConverter;

        public StrategyConverter StrategyConverter {
            set => strategyConverter = value;
        }
        
        public decimal doConvert(decimal input) {
            return strategyConverter.doConvert(input);
        }
    }
}
