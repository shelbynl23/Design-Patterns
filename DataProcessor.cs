using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExam
{
    abstract class DataProcessor 
    {
        public abstract void Read();

        public abstract void Filter();


        public abstract void Write();
    }
}
