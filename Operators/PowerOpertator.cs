using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiSystems.Interpreter
{
    /// <summary>
    /// Power operator.
    /// Usage: numericValue ^ numericValue
    /// Example: 2 ^ 5 = 25
    /// </summary>
    public class PowerOperator : Operator
    {
        public PowerOperator()
        {
        }

        internal override Literal Execute(IConstruct argument1, IConstruct argument2)
        {
            return base.GetTransformedConstruct<Number>(argument1) ^ base.GetTransformedConstruct<Number>(argument2);
        }

        public override string Token
        {
            get 
            {
                return "^";
            }
        }
    }
}