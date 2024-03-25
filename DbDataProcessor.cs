using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExam
{
    class DbDataProcessor : DataProcessor
    {
        public override void Filter()
        {
            Console.WriteLine("reading data from database...");
        }

        public override void Read()
        {
            Console.WriteLine("writing data from database....");
        }

        public override void Write()
        {
            Console.WriteLine("writing data to the database....");
        }
    }
}
