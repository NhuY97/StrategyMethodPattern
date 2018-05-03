using DemoStrategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy.ConcreteStrategy
{
    public class USDConverter : StrategyConverter
    {
        const decimal EXCHANGE_RATE_USD = 22727M;
        public decimal doConvert(decimal input)
        {
            return input * EXCHANGE_RATE_USD;
        }
    }
}
