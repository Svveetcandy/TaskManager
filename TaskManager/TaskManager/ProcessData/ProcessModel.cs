using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager.ProcessData
{
    class ProcessModel
    {
        public string name { get; set; }
        public string id { get; set; }
        public string user { get; set; }
        public string memory { get; set; }
        public string priority { get; set; }
        public string threads { get; set; }
        public ProcessModel(Process process)
        {
            try
            {
                name = process.ProcessName;
                id = process.Id.ToString();
                user = process.MachineName;
                memory = process.PagedSystemMemorySize64.ToString()+" КБ";
                priority = process.PriorityClass.ToString();
                threads = process.Threads.Count.ToString();
            }
            catch
            {
            }

        }

    }
}
