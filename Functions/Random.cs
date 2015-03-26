using System.Collections.Generic;
using System;

namespace HiSystems.Interpreter
{
    /// <summary>
    /// Produce a random integer number between the given two numerical values.
    /// </summary>
    public class RandomFunction : Function
    {
        public override string Name
        {
            get { return "Random"; }
        }

        /// <summary>
        /// NOTE: Be careful, it only randomizes for int-type.
        /// </summary>
        public override Literal Execute(IConstruct[] arguments)
        {
            base.EnsureArgumentCountIs(arguments, 2);

            decimal arg0 = base.GetTransformedArgument<Number>(arguments, 0);
            decimal arg1 = base.GetTransformedArgument<Number>(arguments, 1);

            int min = Convert.ToInt32(arg0);
            int max = Convert.ToInt32(arg1);

            var rnd = new Random();
            int result = rnd.Next(min, max+1);

            return new Number(result);
        }

    }
}
