using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExam
{
    class DataLoader
    {

        List<DataProcessor> dataProc = new List<DataProcessor>();

        public void ProcessData(DataProcessor dataproc)
        {
            dataProc.Add(dataproc);
        }

        public void ProcessBatch()
        {
            foreach (DataProcessor loader in dataProc)
            {
                loader.Read();
                loader.Filter();
                loader.Write();
            }

        }
    }
}
