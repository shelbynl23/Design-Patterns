using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExam
{
    class CsvDataProcessor : DataProcessor
    {
        public override void Read()
        {
            Console.WriteLine("reading data from the CSV-file....");
        }

        public override void Filter ()
        {
            Console.WriteLine("writing data from the CSV-file....");
        }

        public override void Write()
        {
            Console.WriteLine("writing  data to the CSV-file....");
        }
    }
}
