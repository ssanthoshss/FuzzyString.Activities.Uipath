using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace FuzzyMatcH
{
    public class PartialMatch : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> String1 { set; get; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> String2 { set; get; }


        [Category("Output")]
        [RequiredArgument]
        public OutArgument<Int32> Result { set; get; }

        protected override void Execute(CodeActivityContext context)
        {
            string string1 = String1.Get(context);
            string string2 = String2.Get(context);

            Int32 result = FuzzySharp.Fuzz.PartialRatio(string1, string2);
            Result.Set(context, result);
        }
    }

    public class ExactMatch : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> String1 { set; get; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> String2 { set; get; }


        [Category("Output")]
        [RequiredArgument]
        public OutArgument<Int32> Result { set; get; }

        protected override void Execute(CodeActivityContext context)
        {
            string string1 = String1.Get(context);
            string string2 = String2.Get(context);

            Int32 result = FuzzySharp.Fuzz.Ratio(string1, string2);
            Result.Set(context, result);
        }
    }
}

